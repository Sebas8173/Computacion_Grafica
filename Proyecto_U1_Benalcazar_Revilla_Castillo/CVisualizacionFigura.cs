using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Proyecto_U1_Benalcazar_Revilla_Castillo
{
    public class CVisualizacionFigura
    {
        private float t = 0f;
        private readonly float velocidad = 0.05f;
        private float amplitud = 50f;

        public void Actualizar(float frecuencia = 1f, float nuevaAmplitud = 50f)
        {
            t += velocidad * frecuencia;
            amplitud = nuevaAmplitud;
        }

        public void DibujarLissajous(Graphics g, int ancho, int alto, float frecuenciaX = 2f, float frecuenciaY = 3f)
        {
            g.Clear(Color.Black);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            for (int i = 0; i < 3; i++)
            {
                int alpha = 255 - i * 80;
                float grosor = 4f - i * 1f;
                using (Pen pen = new Pen(Color.FromArgb(alpha, Color.LimeGreen), grosor))
                {
                    PointF[] puntos = new PointF[100];
                    for (int j = 0; j < puntos.Length; j++)
                    {
                        float theta = t + (j * 2 * (float)Math.PI / puntos.Length);
                        float escala = amplitud / 50f;
                        float x = (float)(Math.Sin(frecuenciaX * theta) * (ancho / 2.5) * escala) + (ancho / 2);
                        float y = (float)(Math.Sin(frecuenciaY * theta + Math.PI / 2) * (alto / 2.5) * escala) + (alto / 2);
                        puntos[j] = new PointF(x, y);
                    }
                    g.DrawLines(pen, puntos);
                }
            }
        }

        public void DibujarCirculos(Graphics g, int ancho, int alto)
        {
            g.Clear(Color.Black);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            float centroX = ancho / 2f;
            float centroY = alto / 2f;
            for (int i = 0; i < 3; i++)
            {
                int alpha = 255 - i * 80;
                float grosor = 4f - i * 1f;
                float radio = amplitud * 1.5f * (1f + i * 0.1f);
                using (Pen pen = new Pen(Color.FromArgb(alpha, Color.Cyan), grosor))
                {
                    g.DrawEllipse(pen, centroX - radio, centroY - radio, radio * 2, radio * 2);
                }
            }
        }
    }
}