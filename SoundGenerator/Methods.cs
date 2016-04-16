using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.DirectSound;
using Synthesizer;

namespace SoundGenerator
{
    public static class Methods
    {
        public static SecondaryBuffer InitializeBuffer(IntPtr handle)
        {
            // Buffer settings
            Device device = new Device();
            device.SetCooperativeLevel(handle, CooperativeLevel.Normal);

            // WAV format description
            WaveFormat waveFormat = new WaveFormat();
            waveFormat.SamplesPerSecond = Constants.samplesPerSec;
            waveFormat.Channels = Constants.channels;
            waveFormat.FormatTag = WaveFormatTag.Pcm;
            waveFormat.BitsPerSample = 16;
            waveFormat.BlockAlign = (short)(Constants.channels * (waveFormat.BitsPerSample / 8));
            waveFormat.AverageBytesPerSecond = Constants.samplesPerSec * waveFormat.BlockAlign;

            // Buffer description
            uint bufferDuration = 1; // seconds
            BufferDescription bufferDesc = new BufferDescription(waveFormat);
            bufferDesc.DeferLocation = true;
            bufferDesc.BufferBytes = Convert.ToInt32(
                bufferDuration * waveFormat.AverageBytesPerSecond / waveFormat.Channels);
            bufferDesc.ControlFrequency = true;
            bufferDesc.ControlVolume = true;

            SecondaryBuffer buffer = new SecondaryBuffer(bufferDesc, device);
            return buffer;
        }

        public static int NoteFreq(int octave, int index)
        {
            return (int)(44100 / octave * Math.Pow(2, (double)index / 12));
        }

        public static void SavePreset(string path)
        {
            //path = @sfd.FileName;
            //using (FileStream stream = new FileStream(path, FileMode.Create))
            //{
            //    using (BinaryWriter writer = new BinaryWriter(stream))
            //    {
            //        writer.Write(comboBox1.SelectedIndex);
            //        writer.Write(amp1.Value);
            //        writer.Write(freq1.Value);
            //        writer.Write(comboBox2.SelectedIndex);
            //        writer.Write(amp2.Value);
            //        writer.Write(freq2.Value);
            //        writer.Write(comboBox3.SelectedIndex);
            //        writer.Write(amp3.Value);
            //        writer.Write(freq3.Value);
            //        label11.Text = String.Format(Path.GetFileName(path).ToString());
            //    }
            //}
        }

        public static void OpenPreset(string path)
        {

        }
    }
}
