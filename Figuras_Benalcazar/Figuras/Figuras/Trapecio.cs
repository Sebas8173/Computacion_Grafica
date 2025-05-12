using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    internal class Trapecio
    {
        private float mBase;
        private float mSideB;
        private float mHeight;
        private float mSideA;
        private float mPerimeter;
        private float mArea;

        public Trapecio()
        {
            mBase = 0.0f;
            mSideB = 0.0f;
            mHeight = 0.0f;
            mSideA = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtBase, TextBox txtSideB, TextBox txtHeight, TextBox txtSideA)
        {
            try
            {
                mBase = float.Parse(txtBase.Text);
                mSideB = float.Parse(txtSideB.Text);
                mHeight = float.Parse(txtHeight.Text);
                mSideA = float.Parse(txtSideA.Text);

                if (mSideB <= 0 || mSideA <= 0 || mHeight <= 0 || mHeight <= 0)
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

        public void PerimeterTrapecio()
        {
            mPerimeter = mBase + mSideB + mSideA + mSideA;
        }

        public void AreaTrapecio()
        {
            mArea = ((mBase + mSideB) * mHeight) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

    }
}
