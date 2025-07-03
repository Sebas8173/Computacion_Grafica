using System;
using System.Drawing;
using System.Windows.Forms;

namespace Algoritmo_de_punto_medio
{
    public partial class Form1 : Form
    {
        private static Form1 _instance;
        public static Form1 Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new Form1();
                return _instance;
            }
        }

        private CPMedio circulo; // Clase que implementa el algoritmo del punto medio
        private Bitmap lienzo; // Bitmap para dibujar el círculo
        private Point? centro, puntoRadio; // Puntos seleccionados con el mouse
        private bool seleccionandoPuntos = false; // Controla el modo de selección gráfica
        private Button btnSeleccionar; // Botón para selección gráfica

        private Form1()
        {
            InitializeComponent();
            circulo = new CPMedio();
            lienzo = new Bitmap(PCanvas.Width, PCanvas.Height); // Ajustar al tamaño del panel
            InitializeAdditionalControls();
            SetupEvents();
        }

        private void InitializeAdditionalControls()
        {
            // Agregar botón de selección gráfica
            btnSeleccionar = new Button
            {
                Text = "Seleccionar Puntos",
                Location = new Point(47, 273), // Ajustado para alinearse con btnCalcular y btnResetear
                Size = new Size(100, 23),
                UseVisualStyleBackColor = true
            };
            groupBox2.Controls.Add(btnSeleccionar);

            // Configurar el panel
            PCanvas.BackColor = Color.White;
            PCanvas.BorderStyle = BorderStyle.FixedSingle;

            // Ajustar etiquetas para claridad
            lblX0.Text = "X centro:";
            lblY0.Text = "Y centro:";
            lblX1.Text = "Radio:";

            // Ajustar tamaño del formulario
            this.ClientSize = new Size(800, 500);
            this.Text = "Algoritmo del Punto Medio - Círculo";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void SetupEvents()
        {
            btnCalcular.Click += (s, e) =>
            {
                try
                {
                    int xc = int.Parse(txtX0.Text);
                    int yc = int.Parse(txtY0.Text);
                    int r = int.Parse(txtRadio.Text);
                    if (r <= 0) throw new Exception("El radio debe ser mayor a 0.");
                    if (xc < 0 || xc >= PCanvas.Width || yc < 0 || yc >= PCanvas.Height)
                        throw new Exception($"El centro debe estar dentro del lienzo (0-{PCanvas.Width - 1}, 0-{PCanvas.Height - 1}).");

                    lienzo = new Bitmap(PCanvas.Width, PCanvas.Height);
                    circulo.CircleMidPoint(xc, yc, r, lienzo);
                    PCanvas.Invalidate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            btnSeleccionar.Click += (s, e) =>
            {
                seleccionandoPuntos = !seleccionandoPuntos;
                btnSeleccionar.Text = seleccionandoPuntos ? "Cancelar Selección" : "Seleccionar Puntos";
                centro = puntoRadio = null;
                txtX0.Text = txtY0.Text = txtRadio.Text = "";
                lienzo = new Bitmap(PCanvas.Width, PCanvas.Height);
                PCanvas.Invalidate();
            };

            btnResetear.Click += (s, e) =>
            {
                txtX0.Text = txtY0.Text = txtRadio.Text = "";
                centro = puntoRadio = null;
                seleccionandoPuntos = false;
                btnSeleccionar.Text = "Seleccionar Puntos";
                lienzo = new Bitmap(PCanvas.Width, PCanvas.Height);
                PCanvas.Invalidate();
            };

            btnSalir.Click += (s, e) => this.Close();

            PCanvas.Paint += (s, e) =>
            {
                e.Graphics.DrawImage(lienzo, 0, 0);
                if (centro.HasValue)
                    e.Graphics.FillEllipse(Brushes.Red, centro.Value.X - 3, centro.Value.Y - 3, 6, 6);
                if (puntoRadio.HasValue)
                    e.Graphics.FillEllipse(Brushes.Blue, puntoRadio.Value.X - 3, puntoRadio.Value.Y - 3, 6, 6);
            };

            PCanvas.MouseClick += (s, e) =>
            {
                if (!seleccionandoPuntos) return;

                if (!centro.HasValue)
                {
                    centro = e.Location;
                    txtX0.Text = e.X.ToString();
                    txtY0.Text = e.Y.ToString();
                }
                else if (!puntoRadio.HasValue)
                {
                    puntoRadio = e.Location;
                    int dx = e.X - centro.Value.X;
                    int dy = e.Y - centro.Value.Y;
                    int r = (int)Math.Sqrt(dx * dx + dy * dy);
                    txtRadio.Text = r.ToString();
                    seleccionandoPuntos = false;
                    btnSeleccionar.Text = "Seleccionar Puntos";
                }
                PCanvas.Invalidate();
            };
        }

        // Mantener los métodos de evento vacíos para evitar errores si están referenciados en el diseñador
        private void btnCalcular_Click(object sender, EventArgs e) { }
        private void btnResetear_Click(object sender, EventArgs e) { }
        private void btnSalir_Click(object sender, EventArgs e) { }
        private void txtRadio_TextChanged(object sender, EventArgs e) { }
    }
}