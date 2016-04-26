namespace SoundGenerator
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.distPanel = new System.Windows.Forms.Panel();
            this.dist_checkBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.distCutoff = new System.Windows.Forms.TrackBar();
            this.distFreq = new System.Windows.Forms.TrackBar();
            this.distBand = new System.Windows.Forms.TrackBar();
            this.distGain = new System.Windows.Forms.TrackBar();
            this.distEdge = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.reverbPanel = new System.Windows.Forms.Panel();
            this.reverb_checkBox = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.distPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distCutoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distBand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distEdge)).BeginInit();
            this.panel2.SuspendLayout();
            this.reverbPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // distPanel
            // 
            this.distPanel.Controls.Add(this.dist_checkBox);
            this.distPanel.Controls.Add(this.label5);
            this.distPanel.Controls.Add(this.label4);
            this.distPanel.Controls.Add(this.label3);
            this.distPanel.Controls.Add(this.label2);
            this.distPanel.Controls.Add(this.label1);
            this.distPanel.Controls.Add(this.distCutoff);
            this.distPanel.Controls.Add(this.distFreq);
            this.distPanel.Controls.Add(this.distBand);
            this.distPanel.Controls.Add(this.distGain);
            this.distPanel.Controls.Add(this.distEdge);
            this.distPanel.Location = new System.Drawing.Point(193, 12);
            this.distPanel.Name = "distPanel";
            this.distPanel.Size = new System.Drawing.Size(172, 238);
            this.distPanel.TabIndex = 0;
            // 
            // dist_checkBox
            // 
            this.dist_checkBox.AutoSize = true;
            this.dist_checkBox.Location = new System.Drawing.Point(3, 218);
            this.dist_checkBox.Name = "dist_checkBox";
            this.dist_checkBox.Size = new System.Drawing.Size(70, 17);
            this.dist_checkBox.TabIndex = 1;
            this.dist_checkBox.Text = "Distortion";
            this.dist_checkBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cutoff";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CenterFreq";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bandwidth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gain";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Edge";
            // 
            // distCutoff
            // 
            this.distCutoff.Location = new System.Drawing.Point(3, 187);
            this.distCutoff.Maximum = 8000;
            this.distCutoff.Minimum = 100;
            this.distCutoff.Name = "distCutoff";
            this.distCutoff.Size = new System.Drawing.Size(104, 45);
            this.distCutoff.TabIndex = 4;
            this.distCutoff.TickStyle = System.Windows.Forms.TickStyle.None;
            this.distCutoff.Value = 100;
            // 
            // distFreq
            // 
            this.distFreq.Location = new System.Drawing.Point(3, 141);
            this.distFreq.Maximum = 8000;
            this.distFreq.Minimum = 100;
            this.distFreq.Name = "distFreq";
            this.distFreq.Size = new System.Drawing.Size(104, 45);
            this.distFreq.TabIndex = 3;
            this.distFreq.TickStyle = System.Windows.Forms.TickStyle.None;
            this.distFreq.Value = 100;
            // 
            // distBand
            // 
            this.distBand.Location = new System.Drawing.Point(3, 95);
            this.distBand.Maximum = 8000;
            this.distBand.Minimum = 100;
            this.distBand.Name = "distBand";
            this.distBand.Size = new System.Drawing.Size(104, 45);
            this.distBand.TabIndex = 2;
            this.distBand.TickStyle = System.Windows.Forms.TickStyle.None;
            this.distBand.Value = 100;
            // 
            // distGain
            // 
            this.distGain.Location = new System.Drawing.Point(3, 49);
            this.distGain.Maximum = 0;
            this.distGain.Minimum = -60;
            this.distGain.Name = "distGain";
            this.distGain.Size = new System.Drawing.Size(104, 45);
            this.distGain.TabIndex = 1;
            this.distGain.TickStyle = System.Windows.Forms.TickStyle.None;
            this.distGain.Value = -60;
            // 
            // distEdge
            // 
            this.distEdge.Location = new System.Drawing.Point(3, 3);
            this.distEdge.Maximum = 100;
            this.distEdge.Name = "distEdge";
            this.distEdge.Size = new System.Drawing.Size(104, 45);
            this.distEdge.TabIndex = 0;
            this.distEdge.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(374, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 238);
            this.panel2.TabIndex = 1;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(3, 218);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // reverbPanel
            // 
            this.reverbPanel.Controls.Add(this.reverb_checkBox);
            this.reverbPanel.Location = new System.Drawing.Point(12, 12);
            this.reverbPanel.Name = "reverbPanel";
            this.reverbPanel.Size = new System.Drawing.Size(172, 238);
            this.reverbPanel.TabIndex = 2;
            // 
            // reverb_checkBox
            // 
            this.reverb_checkBox.AutoSize = true;
            this.reverb_checkBox.Location = new System.Drawing.Point(3, 218);
            this.reverb_checkBox.Name = "reverb_checkBox";
            this.reverb_checkBox.Size = new System.Drawing.Size(61, 17);
            this.reverb_checkBox.TabIndex = 0;
            this.reverb_checkBox.Text = "Reverb";
            this.reverb_checkBox.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 262);
            this.Controls.Add(this.reverbPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.distPanel);
            this.Name = "Form3";
            this.Text = "Effects";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.distPanel.ResumeLayout(false);
            this.distPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distCutoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distBand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distEdge)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.reverbPanel.ResumeLayout(false);
            this.reverbPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel distPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel reverbPanel;
        private System.Windows.Forms.TrackBar distCutoff;
        private System.Windows.Forms.TrackBar distFreq;
        private System.Windows.Forms.TrackBar distBand;
        private System.Windows.Forms.TrackBar distGain;
        private System.Windows.Forms.TrackBar distEdge;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox dist_checkBox;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox reverb_checkBox;
    }
}