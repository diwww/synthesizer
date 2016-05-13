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
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.freq3 = new System.Windows.Forms.TrackBar();
            this.amp3 = new System.Windows.Forms.TrackBar();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.freq2 = new System.Windows.Forms.TrackBar();
            this.amp2 = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.freq1 = new System.Windows.Forms.TrackBar();
            this.amp1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.graphButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.arp_checkBox = new System.Windows.Forms.CheckBox();
            this.reverb_checkBox = new System.Windows.Forms.CheckBox();
            this.dist_checkBox = new System.Windows.Forms.CheckBox();
            this.recordButton = new System.Windows.Forms.Button();
            this.presets_listBox = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freq3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amp1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.freq3);
            this.panel1.Controls.Add(this.amp3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.freq2);
            this.panel1.Controls.Add(this.amp2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.freq1);
            this.panel1.Controls.Add(this.amp1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 436);
            this.panel1.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(200, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "label11";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(49, 291);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 26;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Frequency";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Amplitude";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Osc3";
            // 
            // freq3
            // 
            this.freq3.LargeChange = 296;
            this.freq3.Location = new System.Drawing.Point(11, 379);
            this.freq3.Maximum = 1500;
            this.freq3.Minimum = 20;
            this.freq3.Name = "freq3";
            this.freq3.Size = new System.Drawing.Size(226, 45);
            this.freq3.SmallChange = 148;
            this.freq3.TabIndex = 28;
            this.freq3.TickFrequency = 148;
            this.freq3.Value = 20;
            this.freq3.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // amp3
            // 
            this.amp3.LargeChange = 6552;
            this.amp3.Location = new System.Drawing.Point(11, 323);
            this.amp3.Maximum = 32760;
            this.amp3.Name = "amp3";
            this.amp3.Size = new System.Drawing.Size(226, 45);
            this.amp3.SmallChange = 3276;
            this.amp3.TabIndex = 27;
            this.amp3.TickFrequency = 3276;
            this.amp3.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(49, 147);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Frequency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Amplitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Osc2";
            // 
            // freq2
            // 
            this.freq2.LargeChange = 296;
            this.freq2.Location = new System.Drawing.Point(11, 235);
            this.freq2.Maximum = 1500;
            this.freq2.Minimum = 20;
            this.freq2.Name = "freq2";
            this.freq2.Size = new System.Drawing.Size(226, 45);
            this.freq2.SmallChange = 148;
            this.freq2.TabIndex = 22;
            this.freq2.TickFrequency = 148;
            this.freq2.Value = 20;
            this.freq2.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // amp2
            // 
            this.amp2.LargeChange = 6552;
            this.amp2.Location = new System.Drawing.Point(11, 179);
            this.amp2.Maximum = 32760;
            this.amp2.Name = "amp2";
            this.amp2.Size = new System.Drawing.Size(226, 45);
            this.amp2.SmallChange = 3276;
            this.amp2.TabIndex = 21;
            this.amp2.TickFrequency = 3276;
            this.amp2.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(49, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Frequency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Amplitude";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Osc1";
            // 
            // freq1
            // 
            this.freq1.LargeChange = 292;
            this.freq1.Location = new System.Drawing.Point(11, 91);
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
            this.amp1.Location = new System.Drawing.Point(11, 35);
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
            this.button1.Location = new System.Drawing.Point(94, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "440";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // graphButton
            // 
            this.graphButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.graphButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.graphButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.graphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphButton.Location = new System.Drawing.Point(14, 3);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(122, 74);
            this.graphButton.TabIndex = 9;
            this.graphButton.Text = "Show Graph";
            this.graphButton.UseVisualStyleBackColor = false;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(16, 389);
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
            this.openButton.Location = new System.Drawing.Point(16, 225);
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
            this.domainUpDown1.Location = new System.Drawing.Point(16, 83);
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
            this.arp_checkBox.Location = new System.Drawing.Point(62, 84);
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
            this.reverb_checkBox.Location = new System.Drawing.Point(16, 132);
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
            this.dist_checkBox.Location = new System.Drawing.Point(16, 109);
            this.dist_checkBox.Name = "dist_checkBox";
            this.dist_checkBox.Size = new System.Drawing.Size(70, 17);
            this.dist_checkBox.TabIndex = 32;
            this.dist_checkBox.Text = "Distortion";
            this.dist_checkBox.UseVisualStyleBackColor = true;
            this.dist_checkBox.CheckedChanged += new System.EventHandler(this.effects_CheckedChanged);
            // 
            // recordButton
            // 
            this.recordButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.recordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordButton.Location = new System.Drawing.Point(16, 181);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(122, 38);
            this.recordButton.TabIndex = 45;
            this.recordButton.Text = "Start Record";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // presets_listBox
            // 
            this.presets_listBox.FormattingEnabled = true;
            this.presets_listBox.Location = new System.Drawing.Point(16, 288);
            this.presets_listBox.Name = "presets_listBox";
            this.presets_listBox.Size = new System.Drawing.Size(120, 95);
            this.presets_listBox.TabIndex = 47;
            this.presets_listBox.SelectedIndexChanged += new System.EventHandler(this.presets_listBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Presets";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.graphButton);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.saveButton);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.openButton);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.domainUpDown1);
            this.panel4.Controls.Add(this.presets_listBox);
            this.panel4.Controls.Add(this.arp_checkBox);
            this.panel4.Controls.Add(this.recordButton);
            this.panel4.Controls.Add(this.reverb_checkBox);
            this.panel4.Controls.Add(this.dist_checkBox);
            this.panel4.Location = new System.Drawing.Point(336, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 436);
            this.panel4.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(494, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 424);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 460);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.freq3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amp1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar freq1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button graphButton;
        private System.Windows.Forms.TrackBar amp1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox arp_checkBox;
        private System.Windows.Forms.CheckBox reverb_checkBox;
        private System.Windows.Forms.CheckBox dist_checkBox;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.ListBox presets_listBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar freq3;
        private System.Windows.Forms.TrackBar amp3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar freq2;
        private System.Windows.Forms.TrackBar amp2;
        private System.Windows.Forms.Label label11;
    }
}

