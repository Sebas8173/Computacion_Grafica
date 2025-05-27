using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figuras_Geometricas
{
    public partial class FrmTrapezoide : Form
    {
        private CTrapezoide ObjPentagono = new CTrapezoide();

        private static FrmTrapezoide instancia;

        public static FrmTrapezoide Obtenerlns()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmTrapezoide();
            }
            return instancia;
        }
        CTrapezoide trap;

        public FrmTrapezoide()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float baseMayor = float.Parse(txtBaseMayor.Text);
                float baseMenor = float.Parse(txtBaseInferior.Text);
                float altura = float.Parse(txtAltura.Text);

                trap = new CTrapezoide(baseMayor, baseMenor, altura);

                txtArea.Text = trap.CalcularArea().ToString("0.00");
                txtPerimetro.Text = trap.CalcularPerimetro().ToString("0.00");

                trap.Dibujar(pictureBox1.CreateGraphics(), pictureBox1);
            }
            catch
            {
                MessageBox.Show("Por favor ingrese valores numericos validos.");
            }
        }

        private void btnlReset_Click(object sender, EventArgs e)
        {
            txtBaseMayor.Clear();
            txtBaseInferior.Clear();
            txtAltura.Clear();
            txtArea.Clear();
            txtPerimetro.Clear();
            pictureBox1.Refresh();

            if (trap != null)
                trap.Reset();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trap != null)
            {
                trap.Escalar(trackBar1.Value);
                trap.Dibujar(pictureBox1.CreateGraphics(), pictureBox1);
            }
        }

        private void btnGiroHorario_Click(object sender, EventArgs e)
        {
            if (trap != null)
            {
                trap.RotarHorario();
                trap.Dibujar(pictureBox1.CreateGraphics(), pictureBox1);
            }
        }

        private void btnGiroAntiHorario_Click(object sender, EventArgs e)
        {
            if (trap != null)
            {
                trap.RotarAntiHorario();
                trap.Dibujar(pictureBox1.CreateGraphics(), pictureBox1);
            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (trap != null)
            {
                trap.MoverIzquierda();
                trap.Dibujar(pictureBox1.CreateGraphics(), pictureBox1);
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (trap != null)
            {
                trap.MoverDerecha();
                trap.Dibujar(pictureBox1.CreateGraphics(), pictureBox1);
            }
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            if (trap != null)
            {
                trap.MoverArriba();
                trap.Dibujar(pictureBox1.CreateGraphics(), pictureBox1);
            }
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            if (trap != null)
            {
                trap.MoverAbajo();
                trap.Dibujar(pictureBox1.CreateGraphics(), pictureBox1);
            }
        }
    }
}
