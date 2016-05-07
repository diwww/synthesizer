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
        public static SecondaryBuffer InitializeBuffer(Form1 form)
        {
            // Buffer settings
            Device device = new Device();
            device.SetCooperativeLevel(form, CooperativeLevel.Normal);

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
            bufferDesc.ControlEffects = true;

            SecondaryBuffer buffer = new SecondaryBuffer(bufferDesc, device);
            return buffer;
        }

        public static int NoteFreq(int octave, int index)
        {
            return (int)(44100 / octave * Math.Pow(2, (double)index / 12));
        }
    }
}
