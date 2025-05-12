using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    internal class PoligonoRegular
    {
        private int mNumber;
        private float mSide;
        private float mApotema;
        private float mPerimeter;
        private float mArea;

        public PoligonoRegular()
        {
            mNumber = 0;
            mSide = 0.0f;
            mApotema = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtNumber, TextBox txtSide, TextBox txtApotema)
        {
            try
            {
                mNumber = int.Parse(txtNumber.Text);
                mSide = float.Parse(txtSide.Text);
                mApotema = float.Parse(txtApotema.Text);

                if (mNumber < 3)
                {
                    throw new Exception("Un polígono debe tener al menos 3 lados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "DATOS NO VÁLIDOS");
            }
        }


        public void PerimeterPoligonoRegular()
        {
            mPerimeter = mNumber * mSide;
        }

        public void AreaPoligonoRegular()
        {
            mArea = (mPerimeter * mApotema) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

    }
}