namespace Synthesizer
{
    public static class Mixer
    {
        public static short[] MixWaves(params Oscillator[] oscs)
        {
            short[] data = new short[Constants.samplesAmount];
            int tempSample;
            int k = 0;

            foreach (var osc in oscs)
            {
                if (osc.Amplitude != 0) k++;
            }
            if (k == 0) k = 1;

            for (int i = 0; i < Constants.samplesAmount; i++)
            {
                tempSample = 0;
                foreach (Oscillator osc in oscs)
                {
                    tempSample += osc.Data[i];
                }
                data[i] = (short)(tempSample / k);
            }
            return data;
        }
    }
}
