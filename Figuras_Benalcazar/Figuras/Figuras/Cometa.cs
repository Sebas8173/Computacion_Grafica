using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    internal class Cometa
    {
        private float mDiagMy;
        private float mDiagMn;
        private float mPerimeter;
        private float mSideA;
        private float mSideB;
        private float mArea;

        public Cometa()
        {
            mDiagMy = 0.0f;
            mDiagMn = 0.0f;
            mSideA = 0.0f;
            mSideB = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtDiagMy, TextBox txtDiagMn, TextBox txtSideA, TextBox txtSideB)
        {
            try
            {
                mSideA = float.Parse(txtSideA.Text);
                mSideB = float.Parse(txtSideB.Text);
                mDiagMy = float.Parse(txtDiagMy.Text);
                mDiagMn = float.Parse(txtDiagMn.Text);

                // Validación
                if (mDiagMy <= mDiagMn)
                {
                    throw new Exception("La diagonal mayor debe ser más grande que la diagonal menor.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese solo números válidos en las casillas.", "Datos no válidos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void PerimeterCometa()
        {
            mPerimeter = 2 * (mSideB + mSideA);
        }

        public void AreaCometa()
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