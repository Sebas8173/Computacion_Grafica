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
    public partial class FrmRectangulo : Form
    {
        Rectangulo objRectangle;
        public FrmRectangulo()
        {
            InitializeComponent();
        }
        public void InitializeData()
        {
            txtWidth.Text = "";
            txtHeight.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtWidth.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objRectangle = new Rectangulo();

            objRectangle.ReadData(txtWidth, txtHeight);
            objRectangle.PerimeterRectangle();
            objRectangle.AreaRectangle();

            objRectangle.PrintData(txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }
    }
}
