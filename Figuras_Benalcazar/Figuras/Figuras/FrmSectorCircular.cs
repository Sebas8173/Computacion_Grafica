using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public partial class FrmSectorCircular : Form
    {
        SectorCircular objSectorCircular;
        public FrmSectorCircular()
        {
            InitializeComponent();
        }
        public void InitializeData()
        {
            txtRadio.Text = "";
            txtAngle.Text = "";
            txtArea.Text = "";
            txtRadio.Focus();
            txtAngle.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objSectorCircular = new SectorCircular();

            objSectorCircular.ReadData(txtAngle, txtRadio);
            objSectorCircular.AreaSectorCircular();

            objSectorCircular.PrintData(txtArea);
        }

        private void lblAngle_Click(object sender, EventArgs e)
        {

        }
    }
}
