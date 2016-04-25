using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.DirectSound;

namespace SoundGenerator
{
    public partial class Form3 : Form
    {
        Form1 mainForm;

        #region Methods

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form1 form)
            : this()
        {
            mainForm = form;
            //form.openFlag_fx = true;
        }

        #endregion Methods

        #region Event handlers

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            //mainForm.openFlag_fx = false;
            mainForm.buffer.SetEffects(null);
        }

        #endregion Event handlers
    }
}
//EffectsDistortion settings = effect.AllParameters;

//settings.Edge = distEdge.Value;
//settings.Gain = distGain.Value;
//settings.PostEqBandwidth = distBand.Value;
//settings.PostEqCenterFrequency = distFreq.Value;
//settings.PreLowpassCutoff = distCutoff.Value;

//effect.AllParameters = settings;