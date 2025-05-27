using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figuras_Geometricas
{
    internal class CPentagono
    {
        private double radio; // radio circunscrito
        private double anguloRotacion; // grados de rotacion
        private float escala;
        private PointF desplazamiento; // para traslacion

        public CPentagono(double radio)
        {
            this.radio = radio;
            this.anguloRotacion = 0;
            this.escala = 1.0f;
            this.desplazamiento = new PointF(0, 0);
        }

        public CPentagono()
        {
        }

        // calcular lado usando radio y trigonometria
        public double CalcularLado()
        {
            // lado = 2 * radio * sen(PI/5)
            return 2 * radio * Math.Sin(Math.PI / 5);
        }

        // calcular perimetro (5 lados iguales)
        public double CalcularPerimetro()
        {
            return 5 * CalcularLado();
        }

        // calcular area
        public double CalcularArea()
        {
            // area = (5/2) * lado * apotema
            // apotema = radio * cos(PI/5)
            double lado = CalcularLado();
            double apotema = radio * Math.Cos(Math.PI / 5);
            return (5.0 / 2.0) * lado * apotema;
        }

        // rotar pentagono (grados)
        public void Rotar(double grados)
        {
            anguloRotacion += grados;
        }

        // escalar pentagono (factor)
        public void Escalar(float factor)
        {
            escala = factor;
        }

        // trasladar pentagono
        public void Trasladar(float dx, float dy)
        {
            desplazamiento.X += dx;
            desplazamiento.Y += dy;
        }

        // dibujar pentagono en PictureBox
        public void Dibujar(PictureBox pictureBox)
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            Pen lapiz = new Pen(Color.DarkGreen, 2);

            int centroX = pictureBox.Width / 2;
            int centroY = pictureBox.Height / 2;

            PointF[] puntos = new PointF[5];

            double anguloInicial = (Math.PI / 2) + (anguloRotacion * Math.PI / 180); // para que un vertice quede arriba

            for (int i = 0; i < 5; i++)
            {
                double angulo = anguloInicial + i * 2 * Math.PI / 5;
                float x = (float)(centroX + desplazamiento.X + escala * radio * Math.Cos(angulo));
                float y = (float)(centroY + desplazamiento.Y - escala * radio * Math.Sin(angulo)); // menos para Y porque eje invertido
                puntos[i] = new PointF(x, y);
            }

            g.DrawPolygon(lapiz, puntos);
            pictureBox.Image = bmp;
        }
    }
}
