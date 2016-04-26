using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.DirectSound;
using Synthesizer;
using CSCore.SoundIn;
using CSCore.Codecs.WAV;
using CSCore.CoreAudioAPI;

namespace SoundGenerator
{
    public static class Methods
    {
        public static IEnumerable<MMDevice> EnumerateWasapiDevices()
        {
            using (MMDeviceEnumerator enumerator = new MMDeviceEnumerator())
            {
                return enumerator.EnumAudioEndpoints(DataFlow.Render, DeviceState.Active);
            }
        }

        public static void DataToWav()
        {
            using (WasapiCapture capture = new WasapiLoopbackCapture())
            {
                //if nessesary, you can choose a device here
                //to do so, simply set the device property of the capture to any MMDevice
                //to choose a device, take a look at the sample here: http://cscore.codeplex.com/

                capture.Device = EnumerateWasapiDevices().First();

                //initialize the selected device for recording
                capture.Initialize();

                //create a wavewriter to write the data to
                using (WaveWriter w = new WaveWriter("dump.wav", capture.WaveFormat))
                {
                    //setup an eventhandler to receive the recorded data
                    capture.DataAvailable += (s, e) =>
                    {
                        //save the recorded audio
                        w.Write(e.Data, e.Offset, e.ByteCount);
                    };

                    //start recording
                    capture.Start();

                    //stop recording
                    capture.Stop();
                }
            }
        }


        //public static CaptureBuffer CaptureBufferInit()
        //{
        //    WaveFormat waveFormat = new WaveFormat();
        //    waveFormat.SamplesPerSecond = Constants.samplesPerSec;
        //    waveFormat.Channels = Constants.channels;
        //    waveFormat.FormatTag = WaveFormatTag.Pcm;
        //    waveFormat.BitsPerSample = 16;
        //    waveFormat.BlockAlign = (short)(Constants.channels * (waveFormat.BitsPerSample / 8));
        //    waveFormat.AverageBytesPerSecond = Constants.samplesPerSec * waveFormat.BlockAlign;

        //    CaptureBufferDescription bufferDesc = new CaptureBufferDescription();
        //    bufferDesc.Format = waveFormat;
        //    uint bufferDuration = 10;
        //    bufferDesc.BufferBytes = Convert.ToInt32(
        //        bufferDuration * waveFormat.AverageBytesPerSecond / waveFormat.Channels);

        //    CaptureDevicesCollection captureDevices = new CaptureDevicesCollection();


        //    Guid speakersGuid = new Guid("d20e3624-6955-49db-ba1b-d1c009ea3942");

        //    Capture cap = new Capture(speakersGuid);

        //    CaptureBuffer buffer = new CaptureBuffer(bufferDesc, cap);

        //    return buffer;

        //}

        public static SecondaryBuffer InitializeBuffer(IntPtr handle)
        {
            // Buffer settings
            Device device = new Device();
            device.SetCooperativeLevel(handle, CooperativeLevel.Normal);

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

        public static void SavePreset(string path)
        {
            //path = @sfd.FileName;
            //using (FileStream stream = new FileStream(path, FileMode.Create))
            //{
            //    using (BinaryWriter writer = new BinaryWriter(stream))
            //    {
            //        writer.Write(comboBox1.SelectedIndex);
            //        writer.Write(amp1.Value);
            //        writer.Write(freq1.Value);
            //        writer.Write(comboBox2.SelectedIndex);
            //        writer.Write(amp2.Value);
            //        writer.Write(freq2.Value);
            //        writer.Write(comboBox3.SelectedIndex);
            //        writer.Write(amp3.Value);
            //        writer.Write(freq3.Value);
            //        label11.Text = String.Format(Path.GetFileName(path).ToString());
            //    }
            //}
        }

        public static void OpenPreset(string path)
        {

        }
    }
}
