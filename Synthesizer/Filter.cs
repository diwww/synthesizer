namespace Synthesizer
{
    public static class Filter
    {
        public static short[] LowPass(short[] data, int cutoff)
        {
            double RC = 1.0 / (cutoff * 2 * 3.14);
            double dt = 1.0 / Constants.samplesPerSec; // SampleRate = 44100
            double alpha = dt / (RC + dt);
            short[] filteredData = new short[data.Length];
            filteredData[0] = data[0];
            for (int i = 1; i < filteredData.Length; i++)
            {
                filteredData[i] = (short)(filteredData[i - 1] + (alpha * (data[i] - filteredData[i - 1])));
            }

            return filteredData;
        }
    }
}