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
    public partial class FrmPoligonoRegular : Form
    {
        PoligonoRegular objPoligonoRegular;
        public FrmPoligonoRegular()
        {
            InitializeComponent();
        }
        public void InitializeData()
        {
            txtNumber.Text = "";
            txtSide.Text = "";
            txtApotema.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtNumber.Focus();
            txtSide.Focus();
            txtApotema.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objPoligonoRegular = new PoligonoRegular();

            objPoligonoRegular.ReadData(txtNumber, txtSide, txtApotema);
            objPoligonoRegular.PerimeterPoligonoRegular();
            objPoligonoRegular.AreaPoligonoRegular();

            objPoligonoRegular.PrintData(txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
