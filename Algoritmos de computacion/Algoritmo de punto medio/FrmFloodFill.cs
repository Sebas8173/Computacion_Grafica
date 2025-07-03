using System;
using System.Drawing;
using System.Windows.Forms;

namespace Algoritmo_de_punto_medio
{
   
    public partial class FrmFloodFill : Form
    {
        // Instancia Singleton
        private static FrmFloodFill _instance;
        public static FrmFloodFill Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FrmFloodFill();
                return _instance;
            }
        }

        private CPMedio circulo; // Clase para dibujar el círculo
        private CFloodFill floodFill; // Clase para el relleno por inundación
        private Bitmap lienzo; // Bitmap para dibujar
        private TextBox txtXc, txtYc, txtRadio; // Campos de texto
        private Panel PCanvas; // Panel para dibujar
        private Point? puntoRelleno; // Punto seleccionado para el relleno
        private bool seleccionandoRelleno = false; // Modo de selección para relleno

        private FrmFloodFill()
        {
            InitializeComponent();
            circulo = new CPMedio();
            floodFill = new CFloodFill();
            lienzo = new Bitmap(400, 400);
            InitializeControls();
        }

        private void InitializeControls()
        {
            // Configuración del formulario
            this.Size = new Size(450, 620);
            this.Text = "Algoritmo del Punto Medio con Relleno por Inundación";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Etiquetas
            Label lblXc = new Label { Text = "X centro:", Location = new Point(10, 20), Size = new Size(60, 20) };
            Label lblYc = new Label { Text = "Y centro:", Location = new Point(10, 50), Size = new Size(60, 20) };
            Label lblRadio = new Label { Text = "Radio:", Location = new Point(10, 80), Size = new Size(60, 20) };

            // Campos de texto
            txtXc = new TextBox { Location = new Point(80, 20), Size = new Size(100, 20) };
            txtYc = new TextBox { Location = new Point(80, 50), Size = new Size(100, 20) };
            txtRadio = new TextBox { Location = new Point(80, 80), Size = new Size(100, 20) };

            // Botones
            Button btnDibujar = new Button { Text = "Dibujar Círculo", Location = new Point(10, 110), Size = new Size(100, 30) };
            Button btnRellenar = new Button { Text = "Rellenar Área", Location = new Point(120, 110), Size = new Size(100, 30) };
            Button btnResetear = new Button { Text = "Resetear", Location = new Point(10, 150), Size = new Size(80, 30) };
            Button btnSalir = new Button { Text = "Salir", Location = new Point(100, 150), Size = new Size(80, 30) };

            // Panel para dibujar
            PCanvas = new Panel
            {
                Location = new Point(10, 190),
                Size = new Size(400, 400),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };

            // Eventos
            btnDibujar.Click += (s, e) =>
            {
                try
                {
                    int xc = int.Parse(txtXc.Text);
                    int yc = int.Parse(txtYc.Text);
                    int r = int.Parse(txtRadio.Text);
                    if (r <= 0) throw new Exception("El radio debe ser mayor a 0.");
                    if (xc < 0 || xc >= PCanvas.Width || yc < 0 || yc >= PCanvas.Height)
                        throw new Exception($"El centro debe estar dentro del lienzo (0-{PCanvas.Width - 1}, 0-{PCanvas.Height - 1}).");

                    lienzo = new Bitmap(PCanvas.Width, PCanvas.Height);
                    circulo.CircleMidPoint(xc, yc, r, lienzo);
                    puntoRelleno = null;
                    PCanvas.Invalidate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            btnRellenar.Click += (s, e) =>
            {
                seleccionandoRelleno = !seleccionandoRelleno;
                btnRellenar.Text = seleccionandoRelleno ? "Cancelar Relleno" : "Rellenar Área";
                puntoRelleno = null;
                PCanvas.Invalidate();
            };

            btnResetear.Click += (s, e) =>
            {
                txtXc.Text = txtYc.Text = txtRadio.Text = "";
                puntoRelleno = null;
                seleccionandoRelleno = false;
                btnRellenar.Text = "Rellenar Área";
                lienzo = new Bitmap(PCanvas.Width, PCanvas.Height);
                PCanvas.Invalidate();
            };

            btnSalir.Click += (s, e) => this.Close();

            floodFill.OnPixelDrawn += () =>
            {
                if (InvokeRequired)
                    Invoke(new Action(() => PCanvas.Invalidate()));
                else
                    PCanvas.Invalidate();
            };

            PCanvas.Paint += (s, e) =>
            {
                e.Graphics.DrawImage(lienzo, 0, 0);
                if (puntoRelleno.HasValue)
                    e.Graphics.FillEllipse(Brushes.Green, puntoRelleno.Value.X - 3, puntoRelleno.Value.Y - 3, 6, 6);
            };

            PCanvas.MouseClick += async (s, e) =>
            {
                if (!seleccionandoRelleno) return;

                puntoRelleno = e.Location;
                await floodFill.FloodFill(lienzo, e.X, e.Y, Color.Blue);
                seleccionandoRelleno = false;
                btnRellenar.Text = "Rellenar Área";
                PCanvas.Invalidate();
            };

            // Agregar controles al formulario
            this.Controls.AddRange(new Control[] { lblXc, lblYc, lblRadio, txtXc, txtYc, txtRadio, btnDibujar, btnRellenar, btnResetear, btnSalir, PCanvas });
        }
    }
}