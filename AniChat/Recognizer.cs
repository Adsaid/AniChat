using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Speech.Recognition;
using NAudio.Wave;
using System.Speech.AudioFormat;
using System.Globalization;

namespace AniChat
{
    class Recognizer
    {
        private string recognizedText = string.Empty;

        public string Recognition(string filePath)
        {
            var waveFormat = new WaveFormat(16000, 16, 1); // Задаємо формат дискретизації 16000 Гц, 16 біт, моно

            using (var reader = new MediaFoundationReader(filePath))
            {
                using (var pcmStream = WaveFormatConversionStream.CreatePcmStream(reader))
                {
                    using (var resampledStream = new WaveFormatConversionStream(waveFormat, reader))
                    {
                        var audioStream = new RawSourceWaveStream(resampledStream, waveFormat);
                        //CultureInfo culture = CultureInfo.InvariantCulture;
                        using (var recognizer = new SpeechRecognitionEngine())
                        {
                            recognizer.LoadGrammar(new DictationGrammar());
                            //recognizer.SpeechRecognized += Recognizer_SpeechRecognized;
                            
                            recognizer.SetInputToAudioStream(audioStream, new SpeechAudioFormatInfo(EncodingFormat.Pcm, 16000, 16, 1, 32000, 2, null));
                            //recognizer.RecognizeAsync(RecognizeMode.Multiple);

                            //recognizer.RecognizeAsyncStop();
                            StringBuilder sb = new StringBuilder();
                            while (true)
                            {
                                try
                                {
                                    var recText = recognizer.Recognize();
                                    if (recText == null)
                                    {
                                        break;
                                    }

                                    sb.Append(recText.Text);
                                }
                                catch (Exception)
                                {
                                    //handle exception      
                                    //...

                                    break;
                                }
                            }
                            recognizedText = sb.ToString();
                        }
                    }
                }
            }

            return recognizedText;
        }

        //private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        //{
        //    if (e.Result != null)
        //    {
        //        recognizedText += e.Result.Text;
        //    }
        //}
    }
}
