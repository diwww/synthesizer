using System;

namespace Synthesizer
{
    [Serializable]
    public class Oscillator
    {
        public enum WaveType { Sine, Square, Triangle, Saw, Noise };

        #region Variables

        WaveType type;
        int amplitude;
        double frequency;
        int samplesPerPeriod;
        double period; // Sine, Square
        short step; // Saw, Triangle
        short[] data;

        #endregion Variables

        #region Properties

        public WaveType Type { get { return type; } }
        public short[] Data { get { return data; } }
        public double Frequency { get { return frequency; } }
        public int Amplitude { get { return amplitude; } }

        #endregion Properties

        #region Methods

        public Oscillator(WaveType T, double freq, int amp)
        {
            type = T;
            amplitude = amp;
            frequency = freq;
            samplesPerPeriod = Convert.ToInt32(Constants.samplesPerSec / (frequency / Constants.channels));
            period = (Math.PI * 2 * frequency) / (Constants.samplesPerSec * Constants.channels);
            step = Convert.ToInt16((amplitude * 2) / samplesPerPeriod);
            data = new short[Constants.samplesAmount];
            NewWave(type);
        }

        private void Sine()
        {
            for (int i = 0; i < Constants.samplesAmount; i++)
            {
                data[i] = (short)(amplitude * Math.Sin(period * i));
            }
        }

        private void Square()
        {
            for (int i = 0; i < Constants.samplesAmount; i++)
            {
                data[i] = (short)(amplitude * Math.Sign(Math.Sin(period * i)));
            }
        }

        private void Saw()
        {
            short tempSample = 0;
            int totalSamplesWritten = 0;
            while (totalSamplesWritten < Constants.samplesAmount)
            {
                tempSample = (short)-amplitude;
                for (int i = 0; (i < samplesPerPeriod) && (totalSamplesWritten < Constants.samplesAmount); i++)
                {
                    tempSample += step;
                    data[totalSamplesWritten] = tempSample;
                    totalSamplesWritten++;
                }
            }
        }

        private void Triangle()
        {
            short tempSample = 0;
            int totalSamplesWritten = 0;
            while (totalSamplesWritten < Constants.samplesAmount)
            {
                tempSample = (short)-amplitude;
                for (int i = 0; (i < samplesPerPeriod) && (totalSamplesWritten < Constants.samplesAmount); i++)
                {
                    tempSample += step;
                    data[totalSamplesWritten] = (short)(2  * Math.Abs(tempSample) - amplitude);  // The only difference from Saw
                    totalSamplesWritten++;
                }
            }
        }

        private void Noise()
        {
            Random rnd = new Random();
            for (int i = 0; i < Constants.samplesAmount; i++)
            {
                data[i] = (short)rnd.Next(-amplitude, amplitude);
            }
        }

        private void NewWave(WaveType type)
        {
            switch (type)
            {
                case WaveType.Sine: Sine(); break;
                case WaveType.Square: Square(); break;
                case WaveType.Triangle: Triangle(); break;
                case WaveType.Saw: Saw(); break;
                case WaveType.Noise: Noise(); break;
                default: break;
            }
        }

        #endregion Methods
    }
}