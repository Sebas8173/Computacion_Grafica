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
    public partial class FrmParalelogramo : Form
    {
        Paralelogramo objParalelogramo;
        public FrmParalelogramo()
        {
            InitializeComponent();
        }
        public void InitializeData()
        {
            txtSideA.Text = "";
            txtSideB.Text = "";
            txtHeight.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtSideA.Focus();
            txtSideB.Focus();
            txtHeight.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objParalelogramo = new Paralelogramo();

            objParalelogramo.ReadData(txtSideA,txtSideB, txtHeight);
            objParalelogramo.PerimeterParalelogramo();
            objParalelogramo.AreaParalelogramo();

            objParalelogramo.PrintData(txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }
    }
}
