using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    internal class Cuadrado
    {
        private float mSide;
        private float mPerimeter;
        private float mArea;

        public Cuadrado()
        {
            mSide = 0.0f; ;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtSide)
        {
            try
            {
                mSide = float.Parse(txtSide.Text);
                if (mSide < 0)
                {
                    MessageBox.Show("El lado debe ser mayor a 0.", "Error de validación");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error\tError\tError\nError\tError\tError\nError\tError\tError", "DATOS NO VALIDOS!");
            }
        }

        public void PerimeterCuadrado()
        {
            mPerimeter = 4 * mSide;
        }

        public void AreaCuadrado()
        {
            mArea = mSide * mSide;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

    }
}
