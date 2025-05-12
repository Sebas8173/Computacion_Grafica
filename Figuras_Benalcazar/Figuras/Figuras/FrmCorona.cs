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
    public partial class FrmCorona : Form
    {
        Corona objCorona;
        public FrmCorona()
        {
            InitializeComponent();
        }
        public void InitializeData()
        {
            txtRadioI.Text = "";
            txtRadioE.Text = "";
            txtArea.Text = "";
            txtRadioE.Focus();
            txtRadioI.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objCorona = new Corona();

            objCorona.ReadData(txtRadioI,txtRadioE);
            objCorona.AreaCuadrado();

            objCorona.PrintData(txtArea);
        }
    }
}
