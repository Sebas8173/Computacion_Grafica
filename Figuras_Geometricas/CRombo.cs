using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figuras_Geometricas
{
    internal class CRombo
    {
        // atributos base
        private double diagonalMayor;
        private double diagonalMenor;

        // transformaciones
        private float escala = 1.0f;
        private float angulo = 0.0f; // en grados
        private int desplazamientoX = 0;
        private int desplazamientoY = 0;

        // constructor
        public CRombo(double dMayor, double dMenor)
        {
            this.diagonalMayor = dMayor;
            this.diagonalMenor = dMenor;
        }

        public CRombo()
        {
        }

        // metodo para calcular el area
        public double CalcularArea()
        {
            return (diagonalMayor * diagonalMenor) / 2;
        }

        // metodo para calcular el perimetro
        public double CalcularPerimetro()
        {
            double lado = Math.Sqrt(Math.Pow(diagonalMayor / 2, 2) + Math.Pow(diagonalMenor / 2, 2));
            return 4 * lado;
        }

        // metodo para escalar
        public void Escalar(float nuevaEscala)
        {
            escala = nuevaEscala;
        }

        // metodo para rotar
        public void Rotar(float grados)
        {
            angulo += grados;
        }

        // metodo para trasladar
        public void Trasladar(int dx, int dy)
        {
            desplazamientoX += dx;
            desplazamientoY += dy;
        }

        // metodo para dibujar el rombo
        public void Dibujar(PictureBox pictureBox)
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            Pen lapiz = new Pen(Color.Blue, 2);

            int centroX = pictureBox.Width / 2 + desplazamientoX;
            int centroY = pictureBox.Height / 2 + desplazamientoY;

            float dMayorEsc = (float)(diagonalMayor * escala);
            float dMenorEsc = (float)(diagonalMenor * escala);

            // puntos originales
            PointF[] puntos = new PointF[4];
            puntos[0] = new PointF(0, -dMayorEsc / 2); // arriba
            puntos[1] = new PointF(dMenorEsc / 2, 0);  // derecha
            puntos[2] = new PointF(0, dMayorEsc / 2);  // abajo
            puntos[3] = new PointF(-dMenorEsc / 2, 0); // izquierda

            // aplicar rotacion y traslacion
            for (int i = 0; i < puntos.Length; i++)
            {
                puntos[i] = RotarPunto(puntos[i], angulo);
                puntos[i].X += centroX;
                puntos[i].Y += centroY;
            }

            g.DrawPolygon(lapiz, puntos);
            pictureBox.Image = bmp;
        }

        // metodo auxiliar para rotar un punto en 2D
        private PointF RotarPunto(PointF punto, float grados)
        {
            float rad = (float)(grados * Math.PI / 180);
            float cos = (float)Math.Cos(rad);
            float sin = (float)Math.Sin(rad);

            float xNuevo = punto.X * cos - punto.Y * sin;
            float yNuevo = punto.X * sin + punto.Y * cos;

            return new PointF(xNuevo, yNuevo);
        }
    }
}
