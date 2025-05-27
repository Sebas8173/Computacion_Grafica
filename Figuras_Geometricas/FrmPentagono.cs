using System;
using System.Windows.Forms;

namespace Figuras_Geometricas
{
    public partial class FrmPentagono : Form
    {

         
        private CPentagono ObjPentagono = new CPentagono();

        private static FrmPentagono instancia;

        public static FrmPentagono Obtenerlns()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmPentagono();
            }
            return instancia;
        }
        
        private CPentagono pentagonoActual;

        public FrmPentagono()
        {
            InitializeComponent();

            trackBar1.Minimum = 1;
            trackBar1.Maximum = 20;
            trackBar1.Value = 10; // escala inicial 1.0
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double radio = double.Parse(txtRadio.Text);
                if (radio <= 0)
                {
                    MessageBox.Show("El radio debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                pentagonoActual = new CPentagono(radio);

                txtArea.Text = pentagonoActual.CalcularArea().ToString("0.00");
                txtPerimetro.Text = pentagonoActual.CalcularPerimetro().ToString("0.00");

                pentagonoActual.Dibujar(pictureBox1);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese solo valores numericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlReset_Click(object sender, EventArgs e)
        {
            txtRadio.Clear();
            txtArea.Clear();
            txtPerimetro.Clear();
            pictureBox1.Image = null;
            trackBar1.Value = 10;
            pentagonoActual = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiroHorario_Click(object sender, EventArgs e)
        {
            if (pentagonoActual != null)
            {
                pentagonoActual.Rotar(10);
                pentagonoActual.Dibujar(pictureBox1);
            }
        }

        private void btnGiroAntiHorario_Click(object sender, EventArgs e)
        {
            if (pentagonoActual != null)
            {
                pentagonoActual.Rotar(-10);
                pentagonoActual.Dibujar(pictureBox1);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (pentagonoActual != null)
            {
                float escala = trackBar1.Value / 10.0f;
                pentagonoActual.Escalar(escala);
                pentagonoActual.Dibujar(pictureBox1);
            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (pentagonoActual != null)
            {
                pentagonoActual.Trasladar(-10, 0);
                pentagonoActual.Dibujar(pictureBox1);
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (pentagonoActual != null)
            {
                pentagonoActual.Trasladar(10, 0);
                pentagonoActual.Dibujar(pictureBox1);
            }
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            if (pentagonoActual != null)
            {
                pentagonoActual.Trasladar(0, -10);
                pentagonoActual.Dibujar(pictureBox1);
            }
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            if (pentagonoActual != null)
            {
                pentagonoActual.Trasladar(0, 10);
                pentagonoActual.Dibujar(pictureBox1);
            }
        }
    }
}
