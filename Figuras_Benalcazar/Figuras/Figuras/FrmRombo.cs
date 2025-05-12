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
    public partial class FrmRombo : Form
    {
        Rombo objRombo; 
        public FrmRombo()
        {
            InitializeComponent();
        }
        public void InitializeData()
        {
            txtDiagMy.Text = "";
            txtDiagMn.Text = "";
            txtSide.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtSide.Focus();
            txtDiagMn.Focus();
            txtDiagMy.Focus();
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
            objRombo = new Rombo();

            objRombo.ReadData(txtDiagMy, txtDiagMn, txtSide);
            objRombo.PerimeterRombo();
            objRombo.AreaRombo();

            objRombo.PrintData(txtPerimeter, txtArea);
        }
    }
}
