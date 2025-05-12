using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    internal class Triangulo
    {  
        private float mSideA;   
        private float mBase;
        private float mSideC;   
        private float mPerimeter;
        private float mArea;
        private float mSemi;

        public Triangulo()
        {
            mBase = 0.0f;
            mSideA = 0.0f;
            mSideC = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtBase, TextBox txtSideA, TextBox txtSideC)
        {
            try
            {
                mSideA = float.Parse(txtSideA.Text);
                mBase = float.Parse(txtBase.Text);
                mSideC = float.Parse(txtSideC.Text);

                // Validar 
                if (mSideA + mBase <= mSideC || mSideA + mSideC <= mBase || mBase + mSideC <= mSideA)
                {
                    MessageBox.Show("Los lados no forman un triángulo válido.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\tError\tError\nError\tError\tError\nError\tError\tError", "DATOS NO VALIDOS!");
            }
        }

        public void PerimeterTriangulo()
        {
            mPerimeter = mSideA + mBase + mSideC;
        }

        public void AreaTriangulo()
        {
            mSemi = mPerimeter / 2;
            mArea = (float)Math.Sqrt(mSemi*(mSemi - mSideA)*(mSemi - mBase)*(mSemi - mSideC));
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

    }
}