using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figuras_Geometricas
{
    public partial class FrmRomboide : Form
    {
        private CRomboide ObjPentagono = new CRomboide();

        private static FrmRomboide instancia;

        public static FrmRomboide Obtenerlns()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmRomboide();
            }
            return instancia;
        }

        CRomboide romboide;

        public FrmRomboide()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float baseR = float.Parse(txtBase.Text);
                float altura = float.Parse(txtAltura.Text);
                float angulo = float.Parse(txtAnguloInterno.Text);

                romboide = new CRomboide(baseR, altura, angulo);

                txtArea.Text = romboide.CalcularArea().ToString("0.00");
                txtPerimetro.Text = romboide.CalcularPerimetro().ToString("0.00");

                romboide.Dibujar(pictureBox1.CreateGraphics(), pictureBox1);
            }
            catch
            {
                MessageBox.Show("Por favor ingrese valores numericos validos.");
            }
        }

        private void btnlReset_Click(object sender, EventArgs e)
        {
            txtBase.Clear();
            txtAltura.Clear();
            txtAnguloInterno.Clear();
            txtArea.Clear();
            txtPerimetro.Clear();
            pictureBox1.Refresh();

            if (romboide != null)
                romboide.Reset();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (romboide != null)
            {
                romboide.Escalar(trackBar1.Value);
                romboide.Dibujar(pictureBox1.CreateGraphics(), pictureBox1);
            }
        }

        private void btnGiroHorario_Click(object sender, EventArgs e)
        {
            if (romboide != null)
            {
                romboide.RotarHorario();
                romboide.Dibujar(pictureBox1.CreateGraphics(), pictureBox1);
            }
        }

        private void btnGiroAntiHorario_Click(object sender, EventArgs e)
        {
            if (romboide != null)
            {
                romboide.RotarAntiHorario();
                romboide.Dibujar(pictureBox1.CreateGraphics(), pictureBox1);
            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (romboide != null)
            {
                romboide.MoverIzquierda();
                romboide.Dibujar(pictureBox1.CreateGraphics(), pictureBox1);
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (romboide != null)
            {
                romboide.MoverDerecha();
                romboide.Dibujar(pictureBox1.CreateGraphics(), pictureBox1);
            }
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            if (romboide != null)
            {
                romboide.MoverArriba();
                romboide.Dibujar(pictureBox1.CreateGraphics(), pictureBox1);
            }
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            if (romboide != null)
            {
                romboide.MoverAbajo();
                romboide.Dibujar(pictureBox1.CreateGraphics(), pictureBox1);
            }
        }
    }
}
