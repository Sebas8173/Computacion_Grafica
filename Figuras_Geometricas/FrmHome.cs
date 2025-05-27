using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Geometricas
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void pentagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPentagono pentagono = FrmPentagono.Obtenerlns();
            pentagono.MdiParent = this;
            pentagono.Show();
            pentagono.BringToFront();
        }
        
        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRomboide romboide = FrmRomboide.Obtenerlns();
            romboide.MdiParent = this;
            romboide.Show();
            romboide.BringToFront();

        }

        private void trapezoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapezoide trapezoide = FrmTrapezoide.Obtenerlns();
            trapezoide.MdiParent = this;
            trapezoide.Show();
            trapezoide.BringToFront();

        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRombo rombo = FrmRombo.Obtenerlns();
            rombo.MdiParent = this;
            rombo.Show();
            rombo.BringToFront();
        }
    }
}
