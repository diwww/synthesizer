namespace Synthesizer
{
    public static class Filter
    {
        public static short[] LowPass(short[] data, int cutoff)
        {
            double RC = 1.0 / (cutoff * 2 * 3.14);
            double dt = 1.0 / Constants.samplesPerSec; // SampleRate = 44100
            double alpha = dt / (RC + dt);

            double stepBegin = System.Math.Abs(data[99] - data[0]) / 100.0;
            double stepEnd = System.Math.Abs(data[44000] - data[44099]) / 100.0;

            short[] filteredData = new short[data.Length];

            filteredData[0] = 0;
            filteredData[44099] = 0;

            if (data[99] < 0)
                stepBegin = -stepBegin;
            for (int i = 1; i < 100; i++)
            {
                filteredData[i] = (short)(filteredData[i - 1] + stepBegin);
            }

            for (int i = 100; i < 43999; i++)
            {
                filteredData[i] = (short)(filteredData[i - 1] + (alpha * (data[i] - filteredData[i - 1])));
            }

            if (data[44000] < 0)
                stepEnd = -stepEnd;

            for (int i = 44099; i >= 44000; i--)
            {
                filteredData[i] = (short)(filteredData[i - 1] + stepEnd);
            }
            return filteredData;
        }
    }
}

//public static short[] LowPass(short[] data, int cutoff)
//       {
//           double RC = 1.0 / (cutoff * 2 * 3.14);
//           double dt = 1.0 / Constants.samplesPerSec; // SampleRate = 44100
//           double alpha = dt / (RC + dt);
//           short[] filteredData = new short[data.Length];
//           filteredData[0] = data[0];
//           for (int i = 1; i < data.Length; i++)
//           {
//               filteredData[i] = (short)(filteredData[i - 1] + (alpha * (data[i] - filteredData[i - 1])));
//           }

//           return filteredData;
//       }