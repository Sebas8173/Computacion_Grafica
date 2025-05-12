using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    internal class Corona
    {
        private float mRadioI;
        private float mRadioE;
        private float mArea;

        public Corona()
        {
            mRadioI = 0.0f; ;
            mRadioE = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtRadioI, TextBox txtRadioE)
        {
            try
            {
                mRadioI = float.Parse(txtRadioI.Text);
                mRadioE = float.Parse(txtRadioE.Text);

                
                if (mRadioE < mRadioI)
                {
                    MessageBox.Show("El radio externo debe ser mayor que el radio interno.", "Error de validación");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error\tError\tError\nError\tError\tError\nError\tError\tError", "DATOS NO VALIDOS!");
            }
        }

        public void AreaCuadrado()
        {
            mArea = (float)(Math.PI * ((mRadioE * mRadioE)-(mRadioI*mRadioI)));
        }

        public void PrintData(TextBox txtArea)
        {
            txtArea.Text = mArea.ToString();
        }
    
    }
}


