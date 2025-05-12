using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    internal class SectorCircular
    {
        private float mRadio;
        private float mAngle;
        private float mArea;

        public SectorCircular()
        {
            mRadio = 0.0f;
            mAngle = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtRadio, TextBox txtAngulo)
        {
            try
            {
                mRadio = float.Parse(txtRadio.Text);
                mAngle = float.Parse(txtAngulo.Text);

                if (mAngle <= 0 || mAngle > 360)
                {
                    throw new ArgumentException("El ángulo debe estar entre 1 y 360 grados.");
                }
            }
            catch (ArgumentException ex) 
            {
                MessageBox.Show(ex.Message, "DATOS NO VÁLIDOS!");
            }
        }


        public void AreaSectorCircular()
        {
            mArea = (float)Math.PI * mRadio * mRadio * mAngle / 360;
        }

        public void PrintData(TextBox txtArea)
        {
            txtArea.Text = mArea.ToString();
        }

    }
}
