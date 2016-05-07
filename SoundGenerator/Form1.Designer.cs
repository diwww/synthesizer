namespace SoundGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.freq1 = new System.Windows.Forms.TrackBar();
            this.amp1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.freq2 = new System.Windows.Forms.TrackBar();
            this.amp2 = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.freq3 = new System.Windows.Forms.TrackBar();
            this.amp3 = new System.Windows.Forms.TrackBar();
            this.graphButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.arp_checkBox = new System.Windows.Forms.CheckBox();
            this.reverb_checkBox = new System.Windows.Forms.CheckBox();
            this.dist_checkBox = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.distCutoff = new System.Windows.Forms.TrackBar();
            this.distFreq = new System.Windows.Forms.TrackBar();
            this.distBand = new System.Windows.Forms.TrackBar();
            this.distGain = new System.Windows.Forms.TrackBar();
            this.distEdge = new System.Windows.Forms.TrackBar();
            this.recordButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.presets_listBox = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amp1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amp2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freq3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distCutoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distBand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distEdge)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.freq1);
            this.panel1.Controls.Add(this.amp1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 141);
            this.panel1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(49, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Frequency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Amplitude";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Osc1";
            // 
            // freq1
            // 
            this.freq1.LargeChange = 292;
            this.freq1.Location = new System.Drawing.Point(14, 95);
            this.freq1.Maximum = 1500;
            this.freq1.Minimum = 20;
            this.freq1.Name = "freq1";
            this.freq1.Size = new System.Drawing.Size(226, 45);
            this.freq1.SmallChange = 148;
            this.freq1.TabIndex = 2;
            this.freq1.TickFrequency = 148;
            this.freq1.Value = 20;
            this.freq1.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // amp1
            // 
            this.amp1.LargeChange = 6552;
            this.amp1.Location = new System.Drawing.Point(14, 44);
            this.amp1.Maximum = 32760;
            this.amp1.Name = "amp1";
            this.amp1.Size = new System.Drawing.Size(226, 45);
            this.amp1.SmallChange = 3276;
            this.amp1.TabIndex = 1;
            this.amp1.TickFrequency = 3276;
            this.amp1.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(536, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(462, 279);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "440";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.freq2);
            this.panel2.Controls.Add(this.amp2);
            this.panel2.Location = new System.Drawing.Point(12, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 141);
            this.panel2.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(49, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Frequency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Amplitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Osc2";
            // 
            // freq2
            // 
            this.freq2.LargeChange = 296;
            this.freq2.Location = new System.Drawing.Point(14, 95);
            this.freq2.Maximum = 1500;
            this.freq2.Minimum = 20;
            this.freq2.Name = "freq2";
            this.freq2.Size = new System.Drawing.Size(226, 45);
            this.freq2.SmallChange = 148;
            this.freq2.TabIndex = 5;
            this.freq2.TickFrequency = 148;
            this.freq2.Value = 20;
            this.freq2.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // amp2
            // 
            this.amp2.LargeChange = 6552;
            this.amp2.Location = new System.Drawing.Point(14, 44);
            this.amp2.Maximum = 32760;
            this.amp2.Name = "amp2";
            this.amp2.Size = new System.Drawing.Size(226, 45);
            this.amp2.SmallChange = 3276;
            this.amp2.TabIndex = 4;
            this.amp2.TickFrequency = 3276;
            this.amp2.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.freq3);
            this.panel3.Controls.Add(this.amp3);
            this.panel3.Location = new System.Drawing.Point(12, 306);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 141);
            this.panel3.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(49, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Frequency";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Amplitude";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Osc3";
            // 
            // freq3
            // 
            this.freq3.LargeChange = 296;
            this.freq3.Location = new System.Drawing.Point(14, 95);
            this.freq3.Maximum = 1500;
            this.freq3.Minimum = 20;
            this.freq3.Name = "freq3";
            this.freq3.Size = new System.Drawing.Size(226, 45);
            this.freq3.SmallChange = 148;
            this.freq3.TabIndex = 8;
            this.freq3.TickFrequency = 148;
            this.freq3.Value = 20;
            this.freq3.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // amp3
            // 
            this.amp3.LargeChange = 6552;
            this.amp3.Location = new System.Drawing.Point(14, 44);
            this.amp3.Maximum = 32760;
            this.amp3.Name = "amp3";
            this.amp3.Size = new System.Drawing.Size(226, 45);
            this.amp3.SmallChange = 3276;
            this.amp3.TabIndex = 7;
            this.amp3.TickFrequency = 3276;
            this.amp3.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // graphButton
            // 
            this.graphButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.graphButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.graphButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.graphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphButton.Location = new System.Drawing.Point(336, 12);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(122, 74);
            this.graphButton.TabIndex = 9;
            this.graphButton.Text = "Show Graph";
            this.graphButton.UseVisualStyleBackColor = false;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(462, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(336, 408);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(122, 38);
            this.saveButton.TabIndex = 10;
            this.saveButton.TabStop = false;
            this.saveButton.Text = "Save Preset";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.openButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.openButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.Location = new System.Drawing.Point(336, 248);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(122, 38);
            this.openButton.TabIndex = 11;
            this.openButton.TabStop = false;
            this.openButton.Text = "Open Presets";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("1");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Items.Add("8");
            this.domainUpDown1.Items.Add("12");
            this.domainUpDown1.Items.Add("16");
            this.domainUpDown1.Location = new System.Drawing.Point(336, 97);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.ReadOnly = true;
            this.domainUpDown1.Size = new System.Drawing.Size(40, 20);
            this.domainUpDown1.TabIndex = 29;
            this.domainUpDown1.TabStop = false;
            this.domainUpDown1.Text = "domainUpDown1";
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            this.domainUpDown1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listbox_KeyDown);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // arp_checkBox
            // 
            this.arp_checkBox.AutoSize = true;
            this.arp_checkBox.Location = new System.Drawing.Point(383, 99);
            this.arp_checkBox.Name = "arp_checkBox";
            this.arp_checkBox.Size = new System.Drawing.Size(80, 17);
            this.arp_checkBox.TabIndex = 30;
            this.arp_checkBox.Text = "Arpeggiator";
            this.arp_checkBox.UseVisualStyleBackColor = true;
            this.arp_checkBox.CheckedChanged += new System.EventHandler(this.arp_checkBox_CheckedChanged);
            // 
            // reverb_checkBox
            // 
            this.reverb_checkBox.AutoSize = true;
            this.reverb_checkBox.Enabled = false;
            this.reverb_checkBox.Location = new System.Drawing.Point(580, 260);
            this.reverb_checkBox.Name = "reverb_checkBox";
            this.reverb_checkBox.Size = new System.Drawing.Size(61, 17);
            this.reverb_checkBox.TabIndex = 31;
            this.reverb_checkBox.Text = "Reverb";
            this.reverb_checkBox.UseVisualStyleBackColor = true;
            this.reverb_checkBox.CheckedChanged += new System.EventHandler(this.effects_CheckedChanged);
            // 
            // dist_checkBox
            // 
            this.dist_checkBox.AutoSize = true;
            this.dist_checkBox.Location = new System.Drawing.Point(464, 260);
            this.dist_checkBox.Name = "dist_checkBox";
            this.dist_checkBox.Size = new System.Drawing.Size(70, 17);
            this.dist_checkBox.TabIndex = 32;
            this.dist_checkBox.Text = "Distortion";
            this.dist_checkBox.UseVisualStyleBackColor = true;
            this.dist_checkBox.CheckedChanged += new System.EventHandler(this.effects_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(104, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Cutoff";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(104, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "CenterFreq";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(104, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Bandwidth";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(104, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Gain";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(104, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Edge";
            // 
            // distCutoff
            // 
            this.distCutoff.Location = new System.Drawing.Point(3, 187);
            this.distCutoff.Maximum = 8000;
            this.distCutoff.Minimum = 100;
            this.distCutoff.Name = "distCutoff";
            this.distCutoff.Size = new System.Drawing.Size(104, 45);
            this.distCutoff.TabIndex = 37;
            this.distCutoff.TickStyle = System.Windows.Forms.TickStyle.None;
            this.distCutoff.Value = 100;
            this.distCutoff.Scroll += new System.EventHandler(this.distFreq_Scroll);
            // 
            // distFreq
            // 
            this.distFreq.Location = new System.Drawing.Point(3, 141);
            this.distFreq.Maximum = 8000;
            this.distFreq.Minimum = 100;
            this.distFreq.Name = "distFreq";
            this.distFreq.Size = new System.Drawing.Size(104, 45);
            this.distFreq.TabIndex = 36;
            this.distFreq.TickStyle = System.Windows.Forms.TickStyle.None;
            this.distFreq.Value = 100;
            this.distFreq.Scroll += new System.EventHandler(this.distFreq_Scroll);
            // 
            // distBand
            // 
            this.distBand.Location = new System.Drawing.Point(3, 95);
            this.distBand.Maximum = 8000;
            this.distBand.Minimum = 100;
            this.distBand.Name = "distBand";
            this.distBand.Size = new System.Drawing.Size(104, 45);
            this.distBand.TabIndex = 35;
            this.distBand.TickStyle = System.Windows.Forms.TickStyle.None;
            this.distBand.Value = 100;
            this.distBand.Scroll += new System.EventHandler(this.distFreq_Scroll);
            // 
            // distGain
            // 
            this.distGain.Location = new System.Drawing.Point(3, 49);
            this.distGain.Maximum = 0;
            this.distGain.Minimum = -60;
            this.distGain.Name = "distGain";
            this.distGain.Size = new System.Drawing.Size(104, 45);
            this.distGain.TabIndex = 34;
            this.distGain.TickStyle = System.Windows.Forms.TickStyle.None;
            this.distGain.Value = -60;
            this.distGain.Scroll += new System.EventHandler(this.distFreq_Scroll);
            // 
            // distEdge
            // 
            this.distEdge.Location = new System.Drawing.Point(3, 3);
            this.distEdge.Maximum = 100;
            this.distEdge.Name = "distEdge";
            this.distEdge.Size = new System.Drawing.Size(104, 45);
            this.distEdge.TabIndex = 33;
            this.distEdge.TickStyle = System.Windows.Forms.TickStyle.None;
            this.distEdge.Scroll += new System.EventHandler(this.distFreq_Scroll);
            // 
            // recordButton
            // 
            this.recordButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.recordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordButton.Location = new System.Drawing.Point(336, 204);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(122, 38);
            this.recordButton.TabIndex = 45;
            this.recordButton.Text = "Start Record";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.distBand);
            this.panel4.Controls.Add(this.distEdge);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.distGain);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.distFreq);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.distCutoff);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(462, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 242);
            this.panel4.TabIndex = 46;
            // 
            // presets_listBox
            // 
            this.presets_listBox.FormattingEnabled = true;
            this.presets_listBox.Location = new System.Drawing.Point(336, 305);
            this.presets_listBox.Name = "presets_listBox";
            this.presets_listBox.Size = new System.Drawing.Size(120, 95);
            this.presets_listBox.TabIndex = 47;
            this.presets_listBox.SelectedIndexChanged += new System.EventHandler(this.presets_listBox_SelectedIndexChanged);
            this.presets_listBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listbox_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(336, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Presets";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 460);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.presets_listBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.dist_checkBox);
            this.Controls.Add(this.reverb_checkBox);
            this.Controls.Add(this.arp_checkBox);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoundGenerator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amp1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freq2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amp2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freq3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distCutoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distBand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distEdge)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar freq1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar freq2;
        private System.Windows.Forms.TrackBar amp2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar freq3;
        private System.Windows.Forms.TrackBar amp3;
        private System.Windows.Forms.Button graphButton;
        private System.Windows.Forms.TrackBar amp1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox arp_checkBox;
        private System.Windows.Forms.CheckBox reverb_checkBox;
        private System.Windows.Forms.CheckBox dist_checkBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TrackBar distCutoff;
        private System.Windows.Forms.TrackBar distFreq;
        private System.Windows.Forms.TrackBar distBand;
        private System.Windows.Forms.TrackBar distGain;
        private System.Windows.Forms.TrackBar distEdge;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox presets_listBox;
        private System.Windows.Forms.Label label10;
    }
}

