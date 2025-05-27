using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figuras_Geometricas
{
    public partial class FrmRombo : Form
    {
        private CRombo ObjPentagono = new CRombo();

        private static FrmRombo instancia;

        public static FrmRombo Obtenerlns()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmRombo();
            }
            return instancia;
        }

        private CRombo romboActual;

        public FrmRombo()
        {
            InitializeComponent();
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 20;
            trackBar1.Value = 10; // escala inicial = 1.0
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double dMayor = double.Parse(txtDMayor.Text);
                double dMenor = double.Parse(txtDInferior.Text);

                if (dMayor <= 0 || dMenor <= 0)
                {
                    MessageBox.Show("Las diagonales deben ser mayores que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                romboActual = new CRombo(dMayor, dMenor);

                txtArea.Text = romboActual.CalcularArea().ToString("0.00");
                txtPerimetro.Text = romboActual.CalcularPerimetro().ToString("0.00");

                romboActual.Dibujar(pictureBox1);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese solo valores numericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlReset_Click(object sender, EventArgs e)
        {
            txtDMayor.Clear();
            txtDInferior.Clear();
            txtArea.Clear();
            txtPerimetro.Clear();
            pictureBox1.Image = null;
            trackBar1.Value = 10; // volver a escala 1.0
            romboActual = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiroHorario_Click(object sender, EventArgs e)
        {
            if (romboActual != null)
            {
                romboActual.Rotar(10);
                romboActual.Dibujar(pictureBox1);
            }
        }

        private void btnGiroAntiHorario_Click(object sender, EventArgs e)
        {
            if (romboActual != null)
            {
                romboActual.Rotar(-10);
                romboActual.Dibujar(pictureBox1);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (romboActual != null)
            {
                float escala = trackBar1.Value / 10.0f;
                romboActual.Escalar(escala);
                romboActual.Dibujar(pictureBox1);
            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (romboActual != null)
            {
                romboActual.Trasladar(-10, 0);
                romboActual.Dibujar(pictureBox1);
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (romboActual != null)
            {
                romboActual.Trasladar(10, 0);
                romboActual.Dibujar(pictureBox1);
            }
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            if (romboActual != null)
            {
                romboActual.Trasladar(0, -10);
                romboActual.Dibujar(pictureBox1);
            }
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            if (romboActual != null)
            {
                romboActual.Trasladar(0, 10);
                romboActual.Dibujar(pictureBox1);
            }
        }

        // este evento puede quedar vacio si no lo usas
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

    }
}
