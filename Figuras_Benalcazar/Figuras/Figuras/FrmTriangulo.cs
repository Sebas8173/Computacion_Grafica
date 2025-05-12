using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Figuras
{
    public partial class FrmTriangulo : Form
    {
        Triangulo objTriangulo;
        public FrmTriangulo()
        {
            InitializeComponent();
        }
        public void InitializeData()
        {
            txtSideA.Text = "";
            txtBase.Text = "";
            txtSideC.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtSideA.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objTriangulo = new Triangulo();

            objTriangulo.ReadData(txtBase, txtSideA,txtSideC);
            objTriangulo.PerimeterTriangulo();
            objTriangulo.AreaTriangulo();

            objTriangulo.PrintData(txtPerimeter, txtArea);        }

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
