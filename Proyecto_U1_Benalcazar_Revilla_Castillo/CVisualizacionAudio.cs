using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Proyecto_U1_Benalcazar_Revilla_Castillo
{
    public class CVisualizacionAudio
    {
        private readonly int numBarras = 10;
        private readonly float[] frecuencias;
        private readonly Random random;

        public CVisualizacionAudio()
        {
            frecuencias = new float[numBarras];
            random = new Random();
        }

        public void ActualizarFrecuencias(float[] datosAudio = null)
        {
            if (datosAudio == null)
            {
                for (int i = 0; i < numBarras; i++)
                {
                    frecuencias[i] = (float)(Math.Sin(DateTime.Now.Millisecond / 100.0 + i * 0.5) * 50 + 50);
                }
            }
            else
            {
                for (int i = 0; i < Math.Min(numBarras, datosAudio.Length); i++)
                {
                    frecuencias[i] = datosAudio[i] * 100;
                }
            }
        }

        public void DibujarBarras(Graphics g, int ancho, int alto, float amplitud = 50f)
        {
            g.Clear(Color.Black);
            float anchoBarra = ancho / (float)numBarras;
            float escala = Math.Min(Math.Max(amplitud / 50f, 0.5f), 2f); // Limitar rango
            for (int i = 0; i < numBarras; i++)
            {
                float alturaBarra = frecuencias[i] * alto / 100f * escala;
                alturaBarra = Math.Max(1f, alturaBarra);
                RectangleF rect = new RectangleF(i * anchoBarra, alto - alturaBarra, anchoBarra - 4, alturaBarra);
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    rect, Color.Blue, Color.Magenta, LinearGradientMode.Vertical))
                {
                    g.FillRectangle(brush, rect);
                }
            }
        }
    }
}