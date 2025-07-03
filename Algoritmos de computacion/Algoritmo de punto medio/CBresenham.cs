using System;
using System.Drawing;

namespace Algoritmo_de_punto_medio
{
    internal class CBresenham
    {
        public void Bresenham(int x0, int y0, int x1, int y1, Bitmap lienzo)
        {
            // Ajustar coordenadas para centrar en el lienzo (400x400)
            int offsetX = lienzo.Width / 2;
            int offsetY = lienzo.Height / 2;
            x0 += offsetX;
            y0 += offsetY;
            x1 += offsetX;
            y1 += offsetY;

            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;
            int err = dx - dy;

            while (true)
            {
                SetPixelSafe(lienzo, x0, y0);

                if (x0 == x1 && y0 == y1) break;

                int e2 = 2 * err;
                if (e2 > -dy)
                {
                    err -= dy;
                    x0 += sx;
                }
                if (e2 < dx)
                {
                    err += dx;
                    y0 += sy;
                }
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