using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Figuras
{
    internal class Circulo
    {
        private float mRadio;
        private float mPerimeter;
        private float mArea;

        public Circulo()
        {
            mRadio = 0.0f; ;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtSide)
        {
            try
            {
                mRadio = float.Parse(txtSide.Text);
                if (mRadio < 0)
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

        public void PerimeterCirculo()
        {
            mPerimeter = (float)(Math.PI * mRadio * 2);
        }

        public void AreaCirculo()
        {
            mArea = (float)(Math.PI * mRadio * mRadio); 
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

    }
}
