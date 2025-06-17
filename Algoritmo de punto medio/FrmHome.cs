using System;
using System.Windows.Forms;

namespace Algoritmo_de_punto_medio
{
    public partial class FrmHome : Form
    {
        // Instancia Singleton
        private static FrmHome _instance;
        public static FrmHome Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FrmHome();
                return _instance;
            }
        }

        private FrmHome() // Constructor privado
        {
            InitializeComponent();
        }

        private void puntoMedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.Instance.Show();
            Form1.Instance.Activate();
        }

        private void dDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grafico_DDA.Instance.Show();
            Grafico_DDA.Instance.Activate();
        }

        private void bresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grafica_Bresenham.Instance.Show();
            Grafica_Bresenham.Instance.Activate();
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFloodFill.Instance.Show();
            FrmFloodFill.Instance.Activate();
        }
    }
}