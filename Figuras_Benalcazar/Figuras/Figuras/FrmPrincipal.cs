using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void AbrirUnicaVentana<T>() where T : Form, new()
        {
            foreach (var form in this.MdiChildren)
            {
                form.Close();
            }

            // Crea y muestra una nueva instancia de la ventana
            var nuevaVentana = new T { MdiParent = this };
            nuevaVentana.Show();
        }

        private void SALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmCuadrado>();
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
             AbrirUnicaVentana<FrmCirculo>(); 
        }

        private void cometaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmCometa>();
        }

        private void paralelogramoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmParalelogramo>();
        }

        private void poligonoRegularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmPoligonoRegular>();
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmRectangulo>();
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmRombo>();
        }

        private void sectorCircularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmSectorCircular>();
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmTrapecio>();
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentana<FrmTriangulo>();
        }
    }
}
