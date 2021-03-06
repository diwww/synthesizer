using System;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;
using Synthesizer;
using Microsoft.DirectX.DirectSound;
using System.Drawing;
using System.Collections.Generic;

namespace SoundGenerator
{
    public partial class Form1 : Form
    {
        #region Variables

        // Oscillator and Mixer variables
        Oscillator.WaveType w1, w2, w3;
        Oscillator[] oscs;
        public short[] waveData, filteredData;
        int octave;
        int k = 0; // Arpeggiator status
        int delta = 500; // How fast volume decreases

        // DirectSound variables
        public SecondaryBuffer buffer;

        // Flags
        public bool openFlag_gr = false;
        bool arpFlag = false;
        bool recordFlag = false;

        // Additional forms
        Form2 f2;

        // Сollections
        HashSet<Keys> pressedKeys;
        Keys[] synthKeys = { Keys.Q, Keys.W, Keys.E, Keys.R, Keys.T, Keys.Y, Keys.U, Keys.D2, Keys.D3, Keys.D5, Keys.D6, Keys.D7 };
        BindingList<Preset> presets = new BindingList<Preset>();

        // File dialogs
        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();
        string path;

        WavFileRecorder recorder;

        #endregion Variables

        # region Event handlers

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            ofd.Multiselect = true;
            presets_listBox.DataSource = presets;
            presets_listBox.ValueMember = "FullName";
            presets_listBox.DisplayMember = "Name";
            pictureBox1.Image = Properties.Resources._0;

            // Initialize list for pressed keys
            Array.Sort<Keys>(synthKeys);
            pressedKeys = new HashSet<Keys>();

            // Octave selection
            domainUpDown1.SelectedIndex = 2;
            octave = Convert.ToInt32(domainUpDown1.SelectedItem);

            // Combobox settings
            comboBox1.DataSource = Enum.GetValues(typeof(Oscillator.WaveType));
            comboBox2.DataSource = Enum.GetValues(typeof(Oscillator.WaveType));
            comboBox3.DataSource = Enum.GetValues(typeof(Oscillator.WaveType));
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;

            try
            {
                buffer = Methods.InitializeBuffer(this);
                GenerateWave();
                buffer.Volume = (int)Volume.Min;
                buffer.Frequency = Methods.NoteFreq(8, 1);
                buffer.Play(0, BufferPlayFlags.Looping);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshLabels();
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            // Disable form cloning
            // and show graph
            if (openFlag_gr == false)
            {
                f2 = new Form2(this);
                f2.Show();
            }
            f2.Refresh();
            f2.BringToFront();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            AddKeys(e);
            try
            {
                PlayNote(e);
            }
            catch (NullReferenceException)
            { }

            if (e.KeyData == Keys.OemOpenBrackets && presets_listBox.SelectedIndex > 0)
            {
                presets_listBox.SelectedIndex--;
            }
            if (e.KeyData == Keys.OemCloseBrackets && presets_listBox.SelectedIndex < presets_listBox.Items.Count - 1)
            {
                presets_listBox.SelectedIndex++;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            StopPlayback(e);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            sfd.Filter = "Synth presets|*.sp";

            if (sfd.ShowDialog() != DialogResult.OK)
                return;
            else
            {
                try
                {
                    path = @sfd.FileName;
                    using (FileStream stream = new FileStream(path, FileMode.Create))
                    {
                        using (BinaryWriter writer = new BinaryWriter(stream))
                        {
                            writer.Write(comboBox1.SelectedIndex);
                            writer.Write(amp1.Value);
                            writer.Write(freq1.Value);

                            writer.Write(comboBox2.SelectedIndex);
                            writer.Write(amp2.Value);
                            writer.Write(freq2.Value);

                            writer.Write(comboBox3.SelectedIndex);
                            writer.Write(amp3.Value);
                            writer.Write(freq3.Value);
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Synth presets|*.sp";

            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            else
            {
                presets.Clear();
                foreach (var name in ofd.FileNames)
                {
                    presets.Add(new Preset(name));
                }
                presets_listBox_SelectedIndexChanged(this, e);
                presets_listBox.Select();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (buffer.Volume != -10000)
            {
                try
                {
                    buffer.Volume -= delta;
                }
                catch (ArgumentException)
                {
                    buffer.Volume = -10000;
                    timer1.Enabled = false;
                }
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (k % 2 == 1)
            {
                timer1.Enabled = false;
                buffer.Volume = (int)Volume.Max;
            }
            else
            {
                timer1.Enabled = true;
            }

            k++;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            octave = Convert.ToInt32(domainUpDown1.SelectedItem);
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateWave();
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            RefreshLabels();
            GenerateWave();
        }

        private void arp_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            arpFlag = arp_checkBox.Checked;
            //if (arpFlag)
            //{
            //    timer1.Interval = 50;
            //    delta = 500;
            //}
            //else
            //{
            //    timer1.Interval = 10;
            //    delta = 100;
            //}
        }

        private void effects_CheckedChanged(object sender, EventArgs e)
        {
            List<EffectDescription> effects = new List<EffectDescription>();
            if (reverb_checkBox.Checked)
            {
                EffectDescription reverb = new EffectDescription { GuidEffectClass = DSoundHelper.StandardWavesReverbGuid };
                effects.Add(reverb);
            }
            if (dist_checkBox.Checked)
            {
                EffectDescription dist = new EffectDescription { GuidEffectClass = DSoundHelper.StandardDistortionGuid };
                effects.Add(dist);
            }

            buffer.Stop();

            if (effects.Count > 0)
            {
                buffer.SetEffects(effects.ToArray());
            }
            else
            {
                buffer.SetEffects(null);
            }

            buffer.Play(0, BufferPlayFlags.Looping);
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            if (recordFlag == false)
            {
                sfd.Filter = "WAV files|*.wav";
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;
                else
                {
                    try
                    {
                        path = @sfd.FileName;
                        recorder = new WavFileRecorder(path);
                        recorder.StartRecord();
                        recordFlag = true;
                        recordButton.Text = "Recording/Stop";
                        recordButton.BackColor = Color.Red;
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (recorder != null)
                {
                    recorder.StopRecord();
                    recorder.Dispose();
                    recorder = null;
                    recordFlag = false;
                    recordButton.Text = "Start Record";
                    recordButton.BackColor = SystemColors.Control;
                }
            }
        }

        private void presets_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (presets.Count > 0)
                {
                    using (FileStream stream = new FileStream(presets_listBox.SelectedValue.ToString(), FileMode.Open))
                    {
                        using (BinaryReader reader = new BinaryReader(stream))
                        {
                            comboBox1.SelectedIndex = (reader.ReadInt32());
                            amp1.Value = reader.ReadInt32();
                            freq1.Value = reader.ReadInt32();

                            comboBox2.SelectedIndex = (reader.ReadInt32());
                            amp2.Value = reader.ReadInt32();
                            freq2.Value = reader.ReadInt32();

                            comboBox3.SelectedIndex = (reader.ReadInt32());
                            amp3.Value = reader.ReadInt32();
                            freq3.Value = reader.ReadInt32();
                        }
                    }
                    RefreshLabels();
                    GenerateWave();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong preset file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                presets.RemoveAt(presets_listBox.SelectedIndex);
                if (presets.Count > 0)
                    presets_listBox.SelectedIndex = 0;
            }
        }

        // Disable controls auto selecting
        // items when pressing key
        private void listbox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void filter_trackBar_Scroll(object sender, EventArgs e)
        {
            label14.Text = "Cutoff\n" + filter_trackBar.Value.ToString() + "Hz";

            if (filter_trackBar.Value < 1000)
            {
                filteredData = Filter.LowPass(waveData, filter_trackBar.Value);
                buffer.Write(0, filteredData, LockFlag.EntireBuffer);
            }
            else
            {
                filteredData = null;
                buffer.Write(0, waveData, LockFlag.EntireBuffer);
                label14.Text = "Off";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (recorder != null)
            {
                recorder.StopRecord();
                recorder.Dispose();
                recorder = null;
                recordFlag = false;
                recordButton.Text = "Start Record";
                recordButton.BackColor = SystemColors.Control;
            }
        }

        #endregion Event handlers

        #region Methods

        // Form constructor
        public Form1()
        {
            InitializeComponent();
        }

        // Add pressed keys to list
        // without repetition,
        // set buffer volume to max,
        // if pressedKeys.Count > 0
        private void AddKeys(KeyEventArgs e)
        {
            if (synthKeys.Contains(e.KeyData))
            {
                pressedKeys.Add(e.KeyData);
                if (k == 0)
                    buffer.Volume = (int)Volume.Max;
            }
        }

        // Play note for the corresponding key
        private void PlayNote(KeyEventArgs e)
        {
            if (pressedKeys.Count > 0)
            {
                if (arpFlag)
                    PlayArp();
                else
                    StopArp();
                if (k == 0)
                    timer1.Enabled = false;
            }

            switch (e.KeyData)
            {
                case Keys.Q:
                    buffer.Frequency = Methods.NoteFreq(octave, 1);
                    pictureBox1.Image = Properties.Resources._1;
                    break;
                case Keys.D2:
                    buffer.Frequency = Methods.NoteFreq(octave, 2);
                    pictureBox1.Image = Properties.Resources._2;
                    break;
                case Keys.W:
                    buffer.Frequency = Methods.NoteFreq(octave, 3);
                    pictureBox1.Image = Properties.Resources._3;
                    break;
                case Keys.D3:
                    buffer.Frequency = Methods.NoteFreq(octave, 4);
                    pictureBox1.Image = Properties.Resources._4;
                    break;
                case Keys.E:
                    buffer.Frequency = Methods.NoteFreq(octave, 5);
                    pictureBox1.Image = Properties.Resources._5;
                    break;
                case Keys.R:
                    buffer.Frequency = Methods.NoteFreq(octave, 6);
                    pictureBox1.Image = Properties.Resources._6;
                    break;
                case Keys.D5:
                    buffer.Frequency = Methods.NoteFreq(octave, 7);
                    pictureBox1.Image = Properties.Resources._7;
                    break;
                case Keys.T:
                    buffer.Frequency = Methods.NoteFreq(octave, 8);
                    pictureBox1.Image = Properties.Resources._8;
                    break;
                case Keys.D6:
                    buffer.Frequency = Methods.NoteFreq(octave, 9);
                    pictureBox1.Image = Properties.Resources._9;
                    break;
                case Keys.Y:
                    buffer.Frequency = Methods.NoteFreq(octave, 10);
                    pictureBox1.Image = Properties.Resources._10;
                    break;
                case Keys.D7:
                    buffer.Frequency = Methods.NoteFreq(octave, 11);
                    pictureBox1.Image = Properties.Resources._11;
                    break;
                case Keys.U:
                    buffer.Frequency = Methods.NoteFreq(octave, 12);
                    pictureBox1.Image = Properties.Resources._12;
                    break;
                default:
                    break;
            }
        }

        private void PlayArp()
        {
            timer2.Enabled = true;
        }

        private void StopArp()
        {
            timer2.Enabled = false;
            k = 0;
        }

        // Remove unpressed keys from list,
        // stop playback, if pressedKeys.Count < 1
        private void StopPlayback(KeyEventArgs e)
        {
            // Remove released keys from list
            pressedKeys.Remove(e.KeyData);

            // if no keys pressed,
            // stop playback
            if (pressedKeys.Count < 1)
            {
                try
                {
                    StopArp();
                    timer1.Enabled = true;
                    pictureBox1.Image = Properties.Resources._0;
                    pressedKeys.Clear();
                }
                catch (NullReferenceException)
                { }
            }
        }

        private void RefreshLabels()
        {
            label2.Text = String.Format("Amplitude\n{0}%", (amp1.Value * 100 / 32760).ToString());
            label5.Text = String.Format("Amplitude\n{0}%", (amp2.Value * 100 / 32760).ToString());
            label8.Text = String.Format("Amplitude\n{0}%", (amp3.Value * 100 / 32760).ToString());
            label3.Text = String.Format("Frequency\n{0}Hz", freq1.Value.ToString());
            label4.Text = String.Format("Frequency\n{0}Hz", freq2.Value.ToString());
            label7.Text = String.Format("Frequency\n{0}Hz", freq3.Value.ToString());
        }

        private void GenerateWave()
        {
            w1 = (Oscillator.WaveType)comboBox1.SelectedItem;
            w2 = (Oscillator.WaveType)comboBox2.SelectedItem;
            w3 = (Oscillator.WaveType)comboBox3.SelectedItem;

            // Creating oscillators
            oscs = new Oscillator[3] { new Oscillator(w1, freq1.Value, amp1.Value), new Oscillator(w2, freq2.Value, amp2.Value), new Oscillator(w3, freq3.Value, amp3.Value) };

            // Writing waveData to array of samples
            waveData = Mixer.MixWaves(oscs);

            // Write to buffer
            buffer.Write(0, waveData, LockFlag.EntireBuffer);

            filter_trackBar.Value = 1000;
            label14.Text = "Off";
        }

        #endregion Methods
    }
}
