namespace Proyecto_U1_Benalcazar_Revilla_Castillo
{
    partial class FrmVentana
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxVisualizacion = new System.Windows.Forms.PictureBox();
            this.panelControles = new System.Windows.Forms.Panel();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.grpVolumen = new System.Windows.Forms.GroupBox();
            this.lstPistas = new System.Windows.Forms.ListBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.cbVisualizacion = new System.Windows.Forms.ComboBox();
            this.trackBarVolumen = new System.Windows.Forms.TrackBar();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.grpProgreso = new System.Windows.Forms.GroupBox();
            this.trackBarProgreso = new System.Windows.Forms.TrackBar();
            this.lblTituloCancion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVolumen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisualizacion)).BeginInit();
            this.panelControles.SuspendLayout();
            this.grpVolumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolumen)).BeginInit();
            this.grpProgreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgreso)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxVisualizacion
            // 
            this.pictureBoxVisualizacion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxVisualizacion.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxVisualizacion.Name = "pictureBoxVisualizacion";
            this.pictureBoxVisualizacion.Size = new System.Drawing.Size(800, 480);
            this.pictureBoxVisualizacion.TabIndex = 0;
            this.pictureBoxVisualizacion.TabStop = false;
            // 
            // panelControles
            // 
            this.panelControles.BackColor = System.Drawing.Color.DarkGray;
            this.panelControles.Controls.Add(this.groupBox1);
            this.panelControles.Controls.Add(this.grpVolumen);
            this.panelControles.Controls.Add(this.grpProgreso);
            this.panelControles.Controls.Add(this.cbVisualizacion);
            this.panelControles.Controls.Add(this.btnPrevious);
            this.panelControles.Controls.Add(this.btnStop);
            this.panelControles.Controls.Add(this.btnNext);
            this.panelControles.Controls.Add(this.btnPause);
            this.panelControles.Controls.Add(this.btnPlay);
            this.panelControles.Location = new System.Drawing.Point(0, 480);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(800, 217);
            this.panelControles.TabIndex = 2;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Verdana", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.White;
            this.lblTiempo.Location = new System.Drawing.Point(10, 40);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(89, 18);
            this.lblTiempo.TabIndex = 11;
            this.lblTiempo.Text = "0:00/0:00";
            // 
            // grpVolumen
            // 
            this.grpVolumen.Controls.Add(this.lblVolumen);
            this.grpVolumen.Controls.Add(this.trackBarVolumen);
            this.grpVolumen.Location = new System.Drawing.Point(467, 12);
            this.grpVolumen.Name = "grpVolumen";
            this.grpVolumen.Size = new System.Drawing.Size(77, 172);
            this.grpVolumen.TabIndex = 9;
            this.grpVolumen.TabStop = false;
            this.grpVolumen.Text = "Vol";
            // 
            // lstPistas
            // 
            this.lstPistas.FormattingEnabled = true;
            this.lstPistas.ItemHeight = 16;
            this.lstPistas.Location = new System.Drawing.Point(12, 65);
            this.lstPistas.Name = "lstPistas";
            this.lstPistas.Size = new System.Drawing.Size(220, 100);
            this.lstPistas.TabIndex = 8;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.LightGray;
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Location = new System.Drawing.Point(12, 21);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(220, 29);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar Musica";
            this.btnCargar.UseVisualStyleBackColor = false;
            // 
            // cbVisualizacion
            // 
            this.cbVisualizacion.DisplayMember = "Seleccionar";
            this.cbVisualizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVisualizacion.FormattingEnabled = true;
            this.cbVisualizacion.Items.AddRange(new object[] {
            "Ecualizador",
            "Lissajous",
            "Círculos"});
            this.cbVisualizacion.Location = new System.Drawing.Point(300, 35);
            this.cbVisualizacion.Name = "cbVisualizacion";
            this.cbVisualizacion.Size = new System.Drawing.Size(150, 24);
            this.cbVisualizacion.TabIndex = 4;
            // 
            // trackBarVolumen
            // 
            this.trackBarVolumen.BackColor = System.Drawing.Color.DarkGray;
            this.trackBarVolumen.Location = new System.Drawing.Point(15, 18);
            this.trackBarVolumen.Maximum = 100;
            this.trackBarVolumen.Name = "trackBarVolumen";
            this.trackBarVolumen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVolumen.Size = new System.Drawing.Size(56, 122);
            this.trackBarVolumen.TabIndex = 6;
            this.trackBarVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVolumen.Value = 50;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.LightGray;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(240, 35);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(50, 30);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.LightGray;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(120, 35);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(50, 30);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "■";
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightGray;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(180, 35);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 30);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.LightGray;
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(60, 35);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(50, 30);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "❚❚";
            this.btnPause.UseVisualStyleBackColor = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.LightGray;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(0, 35);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(50, 30);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "▶";
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // grpProgreso
            // 
            this.grpProgreso.Controls.Add(this.lblTiempo);
            this.grpProgreso.Controls.Add(this.trackBarProgreso);
            this.grpProgreso.Location = new System.Drawing.Point(10, 106);
            this.grpProgreso.Name = "grpProgreso";
            this.grpProgreso.Size = new System.Drawing.Size(446, 78);
            this.grpProgreso.TabIndex = 10;
            this.grpProgreso.TabStop = false;
            this.grpProgreso.Text = "Progreso";
            // 
            // trackBarProgreso
            // 
            this.trackBarProgreso.CausesValidation = false;
            this.trackBarProgreso.Location = new System.Drawing.Point(14, 16);
            this.trackBarProgreso.Maximum = 100;
            this.trackBarProgreso.Name = "trackBarProgreso";
            this.trackBarProgreso.Size = new System.Drawing.Size(400, 56);
            this.trackBarProgreso.TabIndex = 5;
            this.trackBarProgreso.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblTituloCancion
            // 
            this.lblTituloCancion.AutoSize = true;
            this.lblTituloCancion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTituloCancion.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCancion.ForeColor = System.Drawing.Color.White;
            this.lblTituloCancion.Location = new System.Drawing.Point(10, 35);
            this.lblTituloCancion.Name = "lblTituloCancion";
            this.lblTituloCancion.Size = new System.Drawing.Size(273, 20);
            this.lblTituloCancion.TabIndex = 3;
            this.lblTituloCancion.Text = "Nombre de la canción - Artista";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstPistas);
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Location = new System.Drawing.Point(550, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 175);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Musica";
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Font = new System.Drawing.Font("Verdana", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumen.ForeColor = System.Drawing.Color.White;
            this.lblVolumen.Location = new System.Drawing.Point(12, 141);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(44, 18);
            this.lblVolumen.TabIndex = 7;
            this.lblVolumen.Text = "50%";
            // 
            // FrmVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 715);
            this.Controls.Add(this.lblTituloCancion);
            this.Controls.Add(this.panelControles);
            this.Controls.Add(this.pictureBoxVisualizacion);
            this.Name = "FrmVentana";
            this.Text = "FrmVentana";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisualizacion)).EndInit();
            this.panelControles.ResumeLayout(false);
            this.grpVolumen.ResumeLayout(false);
            this.grpVolumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolumen)).EndInit();
            this.grpProgreso.ResumeLayout(false);
            this.grpProgreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgreso)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxVisualizacion;
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TrackBar trackBarVolumen;
        private System.Windows.Forms.TrackBar trackBarProgreso;
        private System.Windows.Forms.Label lblTituloCancion;
        private System.Windows.Forms.ComboBox cbVisualizacion;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ListBox lstPistas;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.GroupBox grpProgreso;
        private System.Windows.Forms.GroupBox grpVolumen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblVolumen;
    }
}