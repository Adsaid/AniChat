using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NAudio.Wave;

namespace AniChat
{
    class Recorder
    {
        private WaveInEvent waveIn;
        private WaveFileWriter writer;

        public void StartRecording(string filePath)
        {
            waveIn = new WaveInEvent();
            waveIn.WaveFormat = new WaveFormat(48000, 1); // 48kHz mono
            waveIn.DataAvailable += WaveIn_DataAvailable;

            writer = new WaveFileWriter(filePath, waveIn.WaveFormat);

            waveIn.StartRecording();
        }

        public void StopRecording()
        {
            waveIn.StopRecording();
            writer.Close();
            writer?.Dispose();
            writer = null;
            waveIn?.Dispose();
            waveIn = null;
        }

        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            writer.Write(e.Buffer, 0, e.BytesRecorded);
        }
    }
}
