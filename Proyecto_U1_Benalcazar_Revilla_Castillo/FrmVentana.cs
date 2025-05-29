using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_U1_Benalcazar_Revilla_Castillo
{
    public partial class FrmVentana : Form
    {
        private readonly CVisualizacionAudio visualizacionAudio;
        private readonly CVisualizacionFigura visualizacionFigura;
        private readonly CVentana controlador;
        private readonly Timer timerVisualizacion;
        private readonly Timer timerMarquesina;
        private string tipoVisualizacion = "Ecualizador";
        private float textoOffset = 0f;
        private bool marquesinaPausada = false;
        private DateTime pausaInicio;
        private bool cancionCargada = false;

        public FrmVentana()
        {
            InitializeComponent();
            visualizacionAudio = new CVisualizacionAudio();
            visualizacionFigura = new CVisualizacionFigura();
            controlador = new CVentana();
            timerMarquesina = new Timer { Interval = 20 };
            timerVisualizacion = new Timer { Interval = 30 };

            ConfigurarInterfaz();
            ConfigurarVisualizacion();
        }

        private void ConfigurarInterfaz()
        {
            this.Text = "Reproductor Multimedia";
            this.Size = new System.Drawing.Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.Sizable;

            foreach (Button btn in new[] { btnPlay, btnPause, btnStop, btnNext, btnPrevious, btnCargar })
            {
                btn.MouseEnter += (s, e) => btn.BackColor = Color.SkyBlue;
                btn.MouseLeave += (s, e) => btn.BackColor = Color.LightGray;
                btn.Paint += (s, e) => ControlPaint.DrawBorder(e.Graphics, btn.ClientRectangle,
                    Color.Silver, 1, ButtonBorderStyle.Solid, Color.Silver, 1, ButtonBorderStyle.Solid,
                    Color.Silver, 1, ButtonBorderStyle.Solid, Color.Silver, 1, ButtonBorderStyle.Solid);
            }

            btnCargar.Click += (s, e) =>
            {
                var openFileDialog = new OpenFileDialog
                {
                    Filter = "Archivos de audio|*.mp3;*.wav",
                    Multiselect = true
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    controlador.AgregarPistas(openFileDialog.FileNames);
                    ActualizarListaPistas();
                    trackBarVolumen.Value = 50;
                    controlador.SetVolumen(0.5f);
                    lblVolumen.Text = "50%"; // Inicializar volumen
                    cancionCargada = true;
                    controlador.Play();
                }
            };
            btnPlay.Click += (s, e) => controlador.Play();
            btnPause.Click += (s, e) => controlador.Pause();
            btnStop.Click += (s, e) => controlador.Stop();
            btnNext.Click += (s, e) => { controlador.SiguientePista(); ActualizarListaPistas(); };
            btnPrevious.Click += (s, e) => { controlador.PistaAnterior(); ActualizarListaPistas(); };

            lstPistas.DoubleClick += (s, e) =>
            {
                if (lstPistas.SelectedIndex >= 0)
                {
                    controlador.CargarPista(lstPistas.SelectedIndex);
                    ActualizarListaPistas();
                    controlador.Play();
                    cancionCargada = true;
                }
            };

            trackBarProgreso.Scroll += (s, e) => controlador.SetPosicion(trackBarProgreso.Value);

            trackBarVolumen.Scroll += (s, e) =>
            {
                controlador.SetVolumen(trackBarVolumen.Value / 100f);
                lblVolumen.Text = $"{trackBarVolumen.Value}%"; // Actualizar porcentaje
            };

            timerMarquesina.Tick += (s, e) =>
            {
                if (marquesinaPausada)
                {
                    if ((DateTime.Now - pausaInicio).TotalSeconds >= 1)
                        marquesinaPausada = false;
                    return;
                }
                textoOffset -= 0.3f;
                if (textoOffset < -TextRenderer.MeasureText(lblTituloCancion.Text, lblTituloCancion.Font).Width)
                {
                    textoOffset = panelControles.Width;
                    marquesinaPausada = true;
                    pausaInicio = DateTime.Now;
                }
                lblTituloCancion.Left = (int)textoOffset;
            };
            timerMarquesina.Start();

            if (cbVisualizacion.Items.Count == 0)
            {
                cbVisualizacion.Items.AddRange(new[] { "Ecualizador", "Lissajous", "Círculos" });
                cbVisualizacion.SelectedIndex = 0;
            }
            cbVisualizacion.SelectedIndexChanged += (s, e) => tipoVisualizacion = cbVisualizacion.SelectedItem?.ToString() ?? "Ecualizador";
        }

        private void ActualizarListaPistas()
        {
            lstPistas.Items.Clear();
            foreach (var pista in controlador.ListaPistas)
            {
                lstPistas.Items.Add(Path.GetFileNameWithoutExtension(pista));
            }
            if (controlador.IndicePistaActual >= 0)
            {
                lstPistas.SelectedIndex = controlador.IndicePistaActual;
                lblTituloCancion.Text = Path.GetFileNameWithoutExtension(controlador.ListaPistas[controlador.IndicePistaActual]);
                trackBarProgreso.Maximum = (int)controlador.DuracionTotal;
                lblTiempo.Text = $"{FormatTime(controlador.PosicionActual)} / {FormatTime(controlador.DuracionTotal)}";
            }
            else if (lstPistas.Items.Count > 0)
            {
                lstPistas.SelectedIndex = 0;
            }
        }

        private string FormatTime(float segundos)
        {
            int minutos = (int)(segundos / 60);
            int segs = (int)(segundos % 60);
            return $"{minutos}:{segs:D2}";
        }

        private void ConfigurarVisualizacion()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);

            timerVisualizacion.Tick += (s, e) =>
            {
                if (cancionCargada && controlador.IsPlaying)
                {
                    trackBarProgreso.Value = Math.Min(trackBarProgreso.Maximum, (int)controlador.PosicionActual);
                    lblTiempo.Text = $"{FormatTime(controlador.PosicionActual)} / {FormatTime(controlador.DuracionTotal)}";
                    visualizacionAudio.ActualizarFrecuencias(controlador.Frecuencias);
                    visualizacionFigura.Actualizar(1f, controlador.Amplitud);
                    pictureBoxVisualizacion.Invalidate();
                }
                else
                {
                    pictureBoxVisualizacion.Invalidate();
                }
            };
            timerVisualizacion.Start();

            pictureBoxVisualizacion.Paint += (s, e) =>
            {
                if (!cancionCargada)
                {
                    e.Graphics.Clear(Color.Black);
                    return;
                }
                if (tipoVisualizacion == "Ecualizador")
                    visualizacionAudio.DibujarBarras(e.Graphics, pictureBoxVisualizacion.Width, pictureBoxVisualizacion.Height, controlador.Amplitud);
                else if (tipoVisualizacion == "Lissajous")
                    visualizacionFigura.DibujarLissajous(e.Graphics, pictureBoxVisualizacion.Width, pictureBoxVisualizacion.Height);
                else
                    visualizacionFigura.DibujarCirculos(e.Graphics, pictureBoxVisualizacion.Width, pictureBoxVisualizacion.Height);
            };
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            controlador.Dispose();
            base.OnFormClosing(e);
        }
    }
}