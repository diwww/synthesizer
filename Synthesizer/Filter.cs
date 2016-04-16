namespace Synthesizer
{
    public static class Filter
    {
        public static short[] LowPass(short[] data, int cutoff)
        {
            double RC = 1.0 / (cutoff * 2 * 3.14);
            double dt = 1.0 / 44100; // SampleRate = 44100
            double alpha = dt / (RC + dt);
            int samplesAmount = data.Length;
            short[] filteredData = new short[samplesAmount];
            for (int i = 1; i < samplesAmount; i++)
            {
                filteredData[i] = (short)(filteredData[i - 1] + (alpha * (data[i] - filteredData[i - 1])));
            }
            filteredData[0] = filteredData[filteredData.GetUpperBound(0)];
            return filteredData;
        }

        //public static short[] LowPass(short[] data)
        //{
        //    short[] filteredData = new short[data.Length];
        //    for (int i = 0; i < data.Length; i++)
        //    {
        //        filteredData[i] = (short)(filteredData[i] + 0.3 * (data[i] - filteredData[i]));
        //    }
        //    return filteredData;
        //}

        //public static short[] LowPass(short[] data, int cutoff)
        //{
        //    double RC = 1.0 / (cutoff * 2 * 3.14);
        //    double dt = 1.0 / 44100; // SampleRate = 44100
        //    double alpha = dt / (RC + dt);
        //    int samplesAmount = data.Length;
        //    short[] filteredData = new short[samplesAmount];
        //    filteredData[0] = data[0];
        //    for (int i = 1; i < samplesAmount; i++)
        //    {
        //        filteredData[i] = (short)(filteredData[i - 1] + (alpha * (data[i] - filteredData[i - 1])));
        //    }
        //    return filteredData;
        //}
    }
}
