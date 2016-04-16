namespace Synthesizer
{
    public static class Mixer
    {
        public static short[] MixWaves(params Oscillator[] oscs)
        {
            short[] data = new short[Constants.samplesAmount];
            int tempSample;

            for (int i = 0; i < Constants.samplesAmount; i++)
            {
                tempSample = 0;
                foreach (Oscillator osc in oscs)
                {
                    tempSample += osc.Data[i];
                }
                data[i] = (short)(tempSample / oscs.Length);
            }
            return data;
        }
    }
}
