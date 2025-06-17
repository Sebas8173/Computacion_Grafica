using System;
using System.Drawing;

namespace Algoritmo_de_punto_medio
{
    internal class CPMedio
    {
        public void CircleMidPoint(int xc, int yc, int r, Bitmap lienzo)
        {
            int x = 0;
            int y = r;
            int p = 1 - r;

            // Dibujar los puntos iniciales
            PlotPoints(xc, yc, x, y, lienzo);

            while (x < y)
            {
                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                PlotPoints(xc, yc, x, y, lienzo);
            }
        }

        private void PlotPoints(int xc, int yc, int x, int y, Bitmap lienzo)
        {
            // Ajustar coordenadas para centrar en el lienzo (suponiendo 400x400)
            int offsetX = lienzo.Width / 2;
            int offsetY = lienzo.Height / 2;

            // Dibujar los 8 puntos simétricos
            SetPixelSafe(lienzo, xc + x + offsetX, yc + y + offsetY);
            SetPixelSafe(lienzo, xc - x + offsetX, yc + y + offsetY);
            SetPixelSafe(lienzo, xc + x + offsetX, yc - y + offsetY);
            SetPixelSafe(lienzo, xc - x + offsetX, yc - y + offsetY);
            SetPixelSafe(lienzo, xc + y + offsetX, yc + x + offsetY);
            SetPixelSafe(lienzo, xc - y + offsetX, yc + x + offsetY);
            SetPixelSafe(lienzo, xc + y + offsetX, yc - x + offsetY);
            SetPixelSafe(lienzo, xc - y + offsetX, yc - x + offsetY);
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