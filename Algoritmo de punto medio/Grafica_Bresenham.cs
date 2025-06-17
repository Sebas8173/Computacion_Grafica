using System;
using System.Drawing;
using System.Windows.Forms;

namespace Algoritmo_de_punto_medio
{
    public partial class Grafica_Bresenham : Form
    {
        // Instancia Singleton
        private static Grafica_Bresenham _instance;
        public static Grafica_Bresenham Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new Grafica_Bresenham();
                }
                return _instance;
            }
        }

        private CBresenham linea; // Instancia de la clase CBresenham
        private Bitmap lienzo; // Bitmap para dibujar la línea
        private bool primerClic = true; // Rastrear si es el primer o segundo clic
        private int x0Temp, y0Temp; // Coordenadas temporales para el primer clic

        private Grafica_Bresenham() // Constructor privado para Singleton
        {
            InitializeComponent();
            linea = new CBresenham();
            lienzo = new Bitmap(400, 400); // Tamaño del lienzo

            // Vincular eventos
            PCanvas.Paint += (s, e) =>
            {
                e.Graphics.DrawImage(lienzo, 0, 0);
            };
            PCanvas.MouseClick += PCanvas_MouseClick;
        }

        private void PCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            // Calcular offset del lienzo (centro en 400x400)
            int offsetX = lienzo.Width / 2;
            int offsetY = lienzo.Height / 2;

            // Obtener coordenadas del clic relativas al centro del lienzo
            int x = e.X - offsetX;
            int y = e.Y - offsetY;

            if (primerClic)
            {
                // Primer clic: guardar coordenadas iniciales
                x0Temp = x;
                y0Temp = y;
                txtX0.Text = x.ToString();
                txtY0.Text = y.ToString();
                primerClic = false;
            }
            else
            {
                // Segundo clic: dibujar la línea
                txtX1.Text = x.ToString();
                txtY1.Text = y.ToString();
                lienzo = new Bitmap(400, 400); // Limpiar lienzo
                linea.Bresenham(x0Temp, y0Temp, x, y, lienzo);
                PCanvas.Invalidate(); // Redibujar el panel
                primerClic = true; // Reiniciar para el próximo par de clics
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Vacío, no se especificó lógica para lblX0
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Vacío, no se especificó lógica para lblY0
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int x0 = int.Parse(txtX0.Text);
                int y0 = int.Parse(txtY0.Text);
                int x1 = int.Parse(txtX1.Text);
                int y1 = int.Parse(txtY1.Text);

                // Limpiar el lienzo
                lienzo = new Bitmap(400, 400);
                linea.Bresenham(x0, y0, x1, y1, lienzo);
                PCanvas.Invalidate(); // Redibujar el panel
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            txtX0.Text = "";
            txtY0.Text = "";
            txtX1.Text = "";
            txtY1.Text = "";
            lienzo = new Bitmap(400, 400); // Limpiar lienzo
            PCanvas.Invalidate();
            primerClic = true; // Reiniciar estado de clics
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}