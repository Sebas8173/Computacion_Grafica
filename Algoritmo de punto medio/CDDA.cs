using System;
using System.Drawing;

namespace Algoritmo_de_punto_medio
{
    internal class CDDA
    {
        public void DDA(int x0, int y0, int x1, int y1, Bitmap lienzo)
        {
            // Ajustar coordenadas para centrar en el lienzo (400x400)
            int offsetX = lienzo.Width / 2;
            int offsetY = lienzo.Height / 2;
            x0 += offsetX;
            y0 += offsetY;
            x1 += offsetX;
            y1 += offsetY;

            // Calcular diferencias
            int dx = x1 - x0;
            int dy = y1 - y0;

            // Determinar pasos y dirección
            int steps = Math.Abs(dx) > Math.Abs(dy) ? Math.Abs(dx) : Math.Abs(dy);
            float xIncrement = (float)dx / steps;
            float yIncrement = (float)dy / steps;

            // Inicializar coordenadas
            float x = x0;
            float y = y0;

            // Dibujar el primer píxel
            SetPixelSafe(lienzo, (int)Math.Round(x), (int)Math.Round(y));

            // Iterar y dibujar los píxeles
            for (int i = 0; i < steps; i++)
            {
                x += xIncrement;
                y += yIncrement;
                SetPixelSafe(lienzo, (int)Math.Round(x), (int)Math.Round(y));
            }
        }

        private void SetPixelSafe(Bitmap lienzo, int x, int y)
        {
            // Verificar que las coordenadas estén dentro de los límites del lienzo
            if (x >= 0 && x < lienzo.Width && y >= 0 && y < lienzo.Height)
            {
                lienzo.SetPixel(x, y, Color.Black);
            }
        }
    }
}