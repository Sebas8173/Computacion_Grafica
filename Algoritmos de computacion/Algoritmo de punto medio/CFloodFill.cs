using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace Algoritmo_de_punto_medio
{
    internal class CFloodFill
    {
        // Delegado para notificar que se debe actualizar el lienzo
        public delegate void PixelDrawnHandler();
        public event PixelDrawnHandler OnPixelDrawn;

        public async Task FloodFill(Bitmap lienzo, int x, int y, Color colorRelleno)
        {
            if (lienzo == null || x < 0 || x >= lienzo.Width || y < 0 || y >= lienzo.Height)
                return;

            Color colorFondo = lienzo.GetPixel(x, y);
            if (colorFondo == colorRelleno)
                return;

            Stack<Point> pila = new Stack<Point>();
            pila.Push(new Point(x, y));

            while (pila.Count > 0)
            {
                Point p = pila.Pop();
                int px = p.X;
                int py = p.Y;

                if (px < 0 || px >= lienzo.Width || py < 0 || py >= lienzo.Height)
                    continue;

                if (lienzo.GetPixel(px, py) != colorFondo)
                    continue;

                lienzo.SetPixel(px, py, colorRelleno);
                OnPixelDrawn?.Invoke(); // Notificar que se dibujó un píxel
                await Task.Delay(1); // Retraso para visualización (1ms por píxel)

                pila.Push(new Point(px + 1, py)); // Derecha
                pila.Push(new Point(px - 1, py)); // Izquierda
                pila.Push(new Point(px, py + 1)); // Abajo
                pila.Push(new Point(px, py - 1)); // Arriba
            }
        }
    }
}