using System;
using System.Drawing;
using System.Windows.Forms;

namespace Algoritmo_de_punto_medio
{
    public partial class Grafico_DDA : Form
    {
        // Instancia Singleton
        private static Grafico_DDA _instance;
        public static Grafico_DDA Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new Grafico_DDA();
                }
                return _instance;
            }
        }

        private CDDA linea; // Instancia de la clase CDDA
        private Bitmap lienzo; // Bitmap para dibujar la línea
        private bool primerClic = true; // Rastrear si es el primer o segundo clic
        private int x0Temp, y0Temp; // Coordenadas temporales para el primer clic

        private Grafico_DDA() // Constructor privado para Singleton
        {
            InitializeComponent();
            linea = new CDDA();
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
                primerClic = true;
            }
            
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
                linea.DDA(x0, y0, x1, y1, lienzo);
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