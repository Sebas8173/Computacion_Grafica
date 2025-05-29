using System;
using System.Collections.Generic;
using System.Linq;
using NAudio.Wave;
using System.Threading;

namespace Proyecto_U1_Benalcazar_Revilla_Castillo
{
    public class CVentana
    {
        private IWavePlayer wavePlayer;
        private AudioFileReader audioFileReader;
        private readonly float[] frecuencias = new float[10];
        private float amplitud = 50f;
        private readonly float[] amplitudBuffer = new float[5]; // Para promedio móvil
        private int bufferIndex = 0;
        private readonly Timer timerMuestras;
        private bool isRunning = true;
        private readonly List<string> listaPistas = new List<string>();
        private int indicePistaActual = -1;
        private readonly SampleAggregator sampleAggregator = new SampleAggregator();

        public bool IsPlaying { get; private set; }
        public float[] Frecuencias => frecuencias;
        public float Amplitud => amplitud;
        public float DuracionTotal => audioFileReader != null ? (float)audioFileReader.TotalTime.TotalSeconds : 0f;
        public float PosicionActual => audioFileReader != null ? (float)audioFileReader.CurrentTime.TotalSeconds : 0f;
        public IReadOnlyList<string> ListaPistas => listaPistas.AsReadOnly();
        public int IndicePistaActual => indicePistaActual;

        public CVentana()
        {
            wavePlayer = new WaveOutEvent();
            timerMuestras = new Timer(ProcesarMuestras, null, 0, 30);
        }

        private void ProcesarMuestras(object state)
        {
            if (audioFileReader != null && IsPlaying)
            {
                float[] buffer = new float[256];
                int leidos = audioFileReader.Read(buffer, 0, buffer.Length);
                if (leidos > 0)
                {
                    float suma = 0f;
                    float volumen = audioFileReader.Volume > 0 ? audioFileReader.Volume : 1f; // Evitar división por 0
                    for (int i = 0; i < leidos; i++)
                    {
                        float muestraNormalizada = buffer[i] / volumen; // Normalizar
                        suma += Math.Abs(muestraNormalizada);
                        sampleAggregator.Add(buffer[i]);
                    }
                    float amplitudCruda = (suma / leidos) * 100f;

                    // Promedio móvil
                    amplitudBuffer[bufferIndex] = amplitudCruda;
                    bufferIndex = (bufferIndex + 1) % amplitudBuffer.Length;
                    float sumaBuffer = 0f;
                    int count = 0;
                    for (int i = 0; i < amplitudBuffer.Length; i++)
                    {
                        if (amplitudBuffer[i] > 0)
                        {
                            sumaBuffer += amplitudBuffer[i];
                            count++;
                        }
                    }
                    amplitud = count > 0 ? sumaBuffer / count : 50f; // Valor por defecto si no hay datos

                    float[] fftResultados = sampleAggregator.GetFftResults(frecuencias.Length);
                    for (int i = 0; i < frecuencias.Length; i++)
                    {
                        frecuencias[i] = fftResultados[i];
                    }
                }
            }
        }

        public void AgregarPistas(string[] rutas)
        {
            listaPistas.AddRange(rutas);
            if (indicePistaActual == -1 && listaPistas.Count > 0)
            {
                indicePistaActual = 0;
                CargarPista(indicePistaActual);
            }
        }

        public void CargarPista(int indice)
        {
            if (indice < 0 || indice >= listaPistas.Count) return;
            indicePistaActual = indice;
            if (audioFileReader != null)
            {
                wavePlayer.Stop();
                audioFileReader.Dispose();
            }
            audioFileReader = new AudioFileReader(listaPistas[indice]);
            wavePlayer.Init(audioFileReader);
            IsPlaying = false;
        }

        public void Play()
        {
            if (audioFileReader != null && !IsPlaying)
            {
                wavePlayer.Play();
                IsPlaying = true;
            }
        }

        public void Pause()
        {
            if (IsPlaying)
            {
                wavePlayer.Pause();
                IsPlaying = false;
            }
        }

        public void Stop()
        {
            if (audioFileReader != null)
            {
                wavePlayer.Stop();
                audioFileReader.Position = 0;
                IsPlaying = false;
            }
        }

        public void SiguientePista()
        {
            if (listaPistas.Count > 0)
            {
                int nuevoIndice = (indicePistaActual + 1) % listaPistas.Count;
                CargarPista(nuevoIndice);
                wavePlayer.Play();
                IsPlaying = true;
            }
        }

        public void PistaAnterior()
        {
            if (listaPistas.Count > 0)
            {
                int nuevoIndice = (indicePistaActual - 1 + listaPistas.Count) % listaPistas.Count;
                CargarPista(nuevoIndice);
                wavePlayer.Play();
                IsPlaying = true;
            }
        }

        public void SetPosicion(float segundos)
        {
            if (audioFileReader != null)
            {
                audioFileReader.CurrentTime = TimeSpan.FromSeconds(segundos);
            }
        }

        public void SetVolumen(float volumen)
        {
            if (audioFileReader != null)
            {
                audioFileReader.Volume = volumen;
            }
        }

        public void Dispose()
        {
            isRunning = false;
            timerMuestras?.Dispose();
            wavePlayer?.Dispose();
            audioFileReader?.Dispose();
        }
    }
}