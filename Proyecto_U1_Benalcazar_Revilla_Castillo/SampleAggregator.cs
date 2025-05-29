using System;
using NAudio.Dsp;

namespace Proyecto_U1_Benalcazar_Revilla_Castillo
{
    public class SampleAggregator
    {
        private readonly int fftLength = 256;
        private readonly Complex[] fftBuffer;
        private readonly float[] fftResults;
        private int fftPos;

        public SampleAggregator()
        {
            fftBuffer = new Complex[fftLength];
            fftResults = new float[fftLength / 2];
        }

        public void Add(float value)
        {
            fftBuffer[fftPos].X = value * (float)FastFourierTransform.HammingWindow(fftPos, fftLength);
            fftBuffer[fftPos].Y = 0;
            fftPos++;
            if (fftPos >= fftLength)
            {
                fftPos = 0;
                FastFourierTransform.FFT(true, (int)Math.Log(fftLength, 2.0), fftBuffer);
                for (int i = 0; i < fftLength / 2; i++)
                {
                    float magnitude = (float)Math.Sqrt(fftBuffer[i].X * fftBuffer[i].X + fftBuffer[i].Y * fftBuffer[i].Y);
                    fftResults[i] = magnitude;
                }
            }
        }

        public float[] GetFftResults(int numBarras)
        {
            float[] resultados = new float[numBarras];
            int puntosPorBarra = fftResults.Length / numBarras;
            for (int i = 0; i < numBarras; i++)
            {
                float suma = 0f;
                for (int j = 0; j < puntosPorBarra; j++)
                {
                    suma += fftResults[i * puntosPorBarra + j];
                }
                resultados[i] = suma / puntosPorBarra * 100f; // Escalar
            }
            return resultados;
        }
    }
}