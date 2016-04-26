using System;
using System.Collections.Generic;
using System.Linq;
using CSCore.SoundIn;
using CSCore.Codecs.WAV;
using CSCore.CoreAudioAPI;
using System.IO;

namespace SoundGenerator
{
    class WavFileRecorder : IDisposable
    {
        public string Path { get; private set; }

        WasapiLoopbackCapture capture;
        WaveWriter waveWriter;

        #region Static methods

        public static IEnumerable<MMDevice> EnumerateWasapiDevices()
        {
            using (MMDeviceEnumerator enumerator = new MMDeviceEnumerator())
            {
                return enumerator.EnumAudioEndpoints(DataFlow.Render, DeviceState.Active);
            }
        }

        #endregion Static methods

        #region Object methods

        public WavFileRecorder(string path)
        {
            Path = path;
            capture = new WasapiLoopbackCapture();
            capture.Device = EnumerateWasapiDevices().First();
            capture.Initialize();
            waveWriter = new WaveWriter(new FileStream(Path, FileMode.Create), capture.WaveFormat);
        }

        public void StartRecord()
        {
            // Setup an eventhandler to receive the recorded data
            capture.DataAvailable += (s, c) =>
            {
                waveWriter.Write(c.Data, c.Offset, c.ByteCount);
            };

            capture.Start();
        }

        public void StopRecord()
        {
            capture.Stop();
        }

        public void Dispose()
        {
            if (capture != null)
            {
                capture.Dispose();
                capture = null;
            }
            if (waveWriter != null)
            {
                waveWriter.Dispose();
                waveWriter = null;
            }
        }

        #endregion Object methods
    }
}
