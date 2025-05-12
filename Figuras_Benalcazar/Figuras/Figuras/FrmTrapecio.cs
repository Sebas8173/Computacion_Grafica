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
    public partial class FrmTrapecio : Form
    {
        Trapecio objTrapecio;
        public FrmTrapecio()
        {
            InitializeComponent();
        }
        public void InitializeData()
        {
            txtSideA.Text = "";
            txtSideB.Text = "";
            txtBase.Text = "";
            txtHeight.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtSideA.Focus();
            txtSideB.Focus();
            txtBase.Focus();
            txtHeight.Focus();
        }

        private void lblDiagMn_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objTrapecio = new Trapecio();

            objTrapecio.ReadData(txtSideA, txtSideB, txtBase, txtHeight);
            objTrapecio.PerimeterTrapecio();
            objTrapecio.AreaTrapecio();

            objTrapecio.PrintData(txtPerimeter, txtArea);
        }
    }
}
