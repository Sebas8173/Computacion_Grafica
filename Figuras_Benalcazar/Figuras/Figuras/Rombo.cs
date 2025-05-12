using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Figuras
{
    internal class Rombo
    {
        private float mDiagMy;
        private float mDiagMn;
        private float mPerimeter;
        private float mSide;
        private float mArea;

        public Rombo()
        {
            mDiagMy = 0.0f;
            mDiagMn = 0.0f;
            mSide = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtDiagMy, TextBox txtDiagMn, TextBox txtSide)
        {
            try
            {
                mDiagMy = float.Parse(txtDiagMy.Text);
                mDiagMn = float.Parse(txtDiagMn.Text);
                mSide = float.Parse(txtSide.Text);

                if (mSide <= 0 || mDiagMy <= 0 || mDiagMn <= 0)
                {
                    MessageBox.Show("Los lados debe ser mayor a 0.", "Error de validación");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error\tError\tError\nError\tError\tError\nError\tError\tError", "DATOS NO VALIDOS!");
            }
        }

        public void PerimeterRombo()
        {
            mPerimeter = 4 * mSide;
        }

        public void AreaRombo()
        {
            mArea = (mDiagMy * mDiagMn) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

    }
}