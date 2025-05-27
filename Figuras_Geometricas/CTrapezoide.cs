using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Figuras_Geometricas
{
    internal class CTrapezoide
    {
        private float baseMayor, baseMenor, altura;
        private PointF[] puntos;
        private float escala = 1f;
        private float angulo = 0f;
        private float desplazamientoX = 0f;
        private float desplazamientoY = 0f;

        public CTrapezoide(float baseMayor, float baseMenor, float altura)
        {
            this.baseMayor = baseMayor;
            this.baseMenor = baseMenor;
            this.altura = altura;
            GenerarPuntos();
        }

        public CTrapezoide()
        {
        }

        private void GenerarPuntos()
        {
            float diferencia = (baseMayor - baseMenor) / 2;
            puntos = new PointF[4];

            puntos[0] = new PointF(-baseMenor / 2, altura / 2);        // esquina inferior izquierda
            puntos[1] = new PointF(baseMenor / 2, altura / 2);         // esquina inferior derecha
            puntos[2] = new PointF(baseMayor / 2, -altura / 2);        // esquina superior derecha
            puntos[3] = new PointF(-baseMayor / 2, -altura / 2);       // esquina superior izquierda
        }

        public float CalcularArea()
        {
            return (baseMayor + baseMenor) * altura / 2;
        }

        public float CalcularPerimetro()
        {
            float ladoInclinado = (float)Math.Sqrt(Math.Pow((baseMayor - baseMenor) / 2, 2) + Math.Pow(altura, 2));
            return baseMayor + baseMenor + 2 * ladoInclinado;
        }

        public void Dibujar(Graphics g, PictureBox pb)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            Matrix matriz = new Matrix();
            matriz.Translate(pb.Width / 2f + desplazamientoX, pb.Height / 2f + desplazamientoY);
            matriz.Scale(escala, escala);
            matriz.Rotate(angulo);

            PointF[] copia = (PointF[])puntos.Clone();
            matriz.TransformPoints(copia);

            g.DrawPolygon(Pens.Blue, copia);
            g.FillPolygon(Brushes.LightSkyBlue, copia);
        }

        public void Escalar(float nuevoValor)
        {
            escala = nuevoValor / 10f;
        }

        public void RotarHorario()
        {
            angulo += 10;
        }

        public void RotarAntiHorario()
        {
            angulo -= 10;
        }

        public void MoverArriba()
        {
            desplazamientoY -= 10;
        }

        public void MoverAbajo()
        {
            desplazamientoY += 10;
        }

        public void MoverIzquierda()
        {
            desplazamientoX -= 10;
        }

        public void MoverDerecha()
        {
            desplazamientoX += 10;
        }

        public void Reset()
        {
            escala = 1f;
            angulo = 0f;
            desplazamientoX = 0f;
            desplazamientoY = 0f;
        }
    }
}
