// FrmPrincipal.cs
using System;
using System.Windows.Forms;

namespace Algoritmo_de_punto_medio
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Configura el formulario como contenedor MDI
        }

        private void AbrirUnicaVentana<T>() where T : Form, new()
        {
            // Cierra todos los formularios hijos abiertos
            foreach (var form in this.MdiChildren)
            {
                form.Close();
            }

            // Crea y muestra una nueva instancia del formulario
            var nuevaVentana = new T { MdiParent = this };

            // Ajusta el formulario hijo para que ocupe todo el contenedor MDI
            nuevaVentana.WindowState = FormWindowState.Maximized; // Maximiza el formulario hijo
            // Alternativa: Centrar el formulario hijo
            // nuevaVentana.StartPosition = FormStartPosition.CenterParent;
            // nuevaVentana.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 20);

            nuevaVentana.Show();
        }
        private void AbrirUnicaVentanaSingleton<T>() where T : Form
        {
            // Cierra todos los formularios hijos abiertos
            foreach (var form in this.MdiChildren)
            {
                form.Close();
            }

            // Si T es FrmFloodFill, usa la instancia Singleton
            Form nuevaVentana;

            if (typeof(T) == typeof(FrmFloodFill))
            {
                nuevaVentana = FrmFloodFill.Instance;
            }
            else
            {
                // Crea una nueva instancia de T (esto funcionará para otros formularios sin patrón Singleton)
                nuevaVentana = Activator.CreateInstance<T>();
            }

            nuevaVentana.MdiParent = this;
            nuevaVentana.WindowState = FormWindowState.Maximized;
            nuevaVentana.Show();
        }

        private void floodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentanaSingleton<FrmFloodFill>();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentanaSingleton<Form1>();
        }

        private void dDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentanaSingleton<Grafico_DDA>();
        }

        private void bresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirUnicaVentanaSingleton<Grafica_Bresenham>();
        }
    }
}
