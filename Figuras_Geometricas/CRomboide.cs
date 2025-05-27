using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figuras_Geometricas
{
    internal class CRomboide
    {
        private float baseFigura, altura, angulo;
        private float escala = 1;
        private float centroX = 150, centroY = 100;
        private float[,] puntos = new float[4, 2];

        public CRomboide(float b, float h, float ang)
        {
            baseFigura = b;
            altura = h;
            angulo = ang;

            CalcularVertices();
        }

        public CRomboide()
        {
        }

        private void CalcularVertices()
        {
            float desplazamiento = (float)(altura / Math.Tan(angulo * Math.PI / 180));

            puntos[0, 0] = centroX;
            puntos[0, 1] = centroY;

            puntos[1, 0] = centroX + baseFigura * escala;
            puntos[1, 1] = centroY;

            puntos[2, 0] = centroX + baseFigura * escala - desplazamiento * escala;
            puntos[2, 1] = centroY + altura * escala;

            puntos[3, 0] = centroX - desplazamiento * escala;
            puntos[3, 1] = centroY + altura * escala;
        }

        public float CalcularArea()
        {
            return baseFigura * altura;
        }

        public float CalcularPerimetro()
        {
            return 2 * (baseFigura + (float)(altura / Math.Sin(angulo * Math.PI / 180)));
        }

        public void Dibujar(Graphics g, PictureBox pb)
        {
            pb.Refresh();
            Pen lapiz = new Pen(Color.Blue, 2);
            PointF[] puntosDibujo = new PointF[4];

            for (int i = 0; i < 4; i++)
                puntosDibujo[i] = new PointF(puntos[i, 0], puntos[i, 1]);

            g.DrawPolygon(lapiz, puntosDibujo);
        }

        public void Escalar(int nuevo)
        {
            escala = nuevo / 10f;
            CalcularVertices();
        }

        public void RotarHorario()
        {
            RotarFigura(10);
        }

        public void RotarAntiHorario()
        {
            RotarFigura(-10);
        }

        private void RotarFigura(float grados)
        {
            double rad = grados * Math.PI / 180;
            for (int i = 0; i < 4; i++)
            {
                float x = puntos[i, 0] - centroX;
                float y = puntos[i, 1] - centroY;

                float nuevoX = (float)(x * Math.Cos(rad) - y * Math.Sin(rad));
                float nuevoY = (float)(x * Math.Sin(rad) + y * Math.Cos(rad));

                puntos[i, 0] = centroX + nuevoX;
                puntos[i, 1] = centroY + nuevoY;
            }
        }

        public void MoverIzquierda() => Mover(-10, 0);
        public void MoverDerecha() => Mover(10, 0);
        public void MoverArriba() => Mover(0, -10);
        public void MoverAbajo() => Mover(0, 10);

        private void Mover(float dx, float dy)
        {
            centroX += dx;
            centroY += dy;
            CalcularVertices();
        }

        public void Reset()
        {
            escala = 1;
            centroX = 150;
            centroY = 100;
            CalcularVertices();
        }
    }
}
