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
    public partial class FrmCometa : Form
    {
        Cometa objCometa;
        public FrmCometa()
        {
            InitializeComponent();
        }
        public void InitializeData()
        {
            txtSideA.Text = "";
            txtSideB.Text = "";
            txtDiagMy.Text = "";
            txtDiagMn.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtSideA.Focus();
            txtSideB.Focus();
            txtDiagMy.Focus();
            txtDiagMn.Focus();
        }

        private void lblBase_Click(object sender, EventArgs e)
        {

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
            objCometa = new Cometa();

            objCometa.ReadData(txtSideA, txtSideB, txtDiagMy, txtDiagMn);
            objCometa.PerimeterCometa();
            objCometa.AreaCometa();

            objCometa.PrintData(txtPerimeter, txtArea);
        }
    }
}
