using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Figuras
{
    internal class Paralelogramo
    {
        private float mSideB;
        private float mSideA;
        private float mHeight;
        private float mPerimeter;
        private float mArea;

        public Paralelogramo()
        {
            mSideB = 0.0f;
            mSideA = 0.0f;
            mHeight = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtLong, TextBox txtHeight, TextBox txtSideA)
        {
            try
            {
                mSideB = float.Parse(txtLong.Text);
                mSideA = float.Parse(txtHeight.Text);
                mHeight = float.Parse(txtHeight.Text);

                if (mSideB <= 0 || mSideA <= 0 || mHeight <= 0)
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

        public void PerimeterParalelogramo()
        {
            mPerimeter = 2 * (mSideB + mSideA);
        }

        public void AreaParalelogramo()
        {
            mArea = mSideB * mHeight;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

    }
}