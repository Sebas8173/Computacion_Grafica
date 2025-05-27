namespace Figuras_Geometricas
{
    partial class FrmRomboide
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.btnArriba = new System.Windows.Forms.Button();
            this.btnGiroAntiHorario = new System.Windows.Forms.Button();
            this.btnGiroHorario = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnlReset = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAnguloInterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(358, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(416, 399);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gráfico";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 371);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPerimetro);
            this.groupBox3.Controls.Add(this.txtArea);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(26, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 77);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salidas";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Enabled = false;
            this.txtPerimetro.Location = new System.Drawing.Point(143, 48);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(100, 22);
            this.txtPerimetro.TabIndex = 7;
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(143, 20);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 22);
            this.txtArea.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Perimetro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Area:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.btnGiroAntiHorario);
            this.groupBox2.Controls.Add(this.btnGiroHorario);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnlReset);
            this.groupBox2.Controls.Add(this.btnCalcular);
            this.groupBox2.Location = new System.Drawing.Point(26, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 229);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proceso";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnIzquierda);
            this.groupBox5.Controls.Add(this.btnDerecha);
            this.groupBox5.Controls.Add(this.btnAbajo);
            this.groupBox5.Controls.Add(this.btnArriba);
            this.groupBox5.Location = new System.Drawing.Point(14, 164);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(252, 59);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzquierda.Location = new System.Drawing.Point(27, 16);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(44, 32);
            this.btnIzquierda.TabIndex = 11;
            this.btnIzquierda.Text = "←";
            this.btnIzquierda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDerecha.Location = new System.Drawing.Point(177, 16);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(46, 32);
            this.btnDerecha.TabIndex = 10;
            this.btnDerecha.Text = "→";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnAbajo
            // 
            this.btnAbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbajo.Location = new System.Drawing.Point(129, 16);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(42, 32);
            this.btnAbajo.TabIndex = 9;
            this.btnAbajo.Text = "↓";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.btnAbajo_Click);
            // 
            // btnArriba
            // 
            this.btnArriba.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArriba.Location = new System.Drawing.Point(77, 16);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(46, 32);
            this.btnArriba.TabIndex = 8;
            this.btnArriba.Text = "↑";
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // btnGiroAntiHorario
            // 
            this.btnGiroAntiHorario.Location = new System.Drawing.Point(143, 141);
            this.btnGiroAntiHorario.Name = "btnGiroAntiHorario";
            this.btnGiroAntiHorario.Size = new System.Drawing.Size(123, 23);
            this.btnGiroAntiHorario.TabIndex = 6;
            this.btnGiroAntiHorario.Text = "Giro Antihorario";
            this.btnGiroAntiHorario.UseVisualStyleBackColor = true;
            this.btnGiroAntiHorario.Click += new System.EventHandler(this.btnGiroAntiHorario_Click);
            // 
            // btnGiroHorario
            // 
            this.btnGiroHorario.Location = new System.Drawing.Point(14, 141);
            this.btnGiroHorario.Name = "btnGiroHorario";
            this.btnGiroHorario.Size = new System.Drawing.Size(123, 23);
            this.btnGiroHorario.TabIndex = 5;
            this.btnGiroHorario.Text = "Giro Horario";
            this.btnGiroHorario.UseVisualStyleBackColor = true;
            this.btnGiroHorario.Click += new System.EventHandler(this.btnGiroHorario_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trackBar1.Location = new System.Drawing.Point(14, 79);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(252, 56);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(143, 50);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnlReset
            // 
            this.btnlReset.Location = new System.Drawing.Point(14, 50);
            this.btnlReset.Name = "btnlReset";
            this.btnlReset.Size = new System.Drawing.Size(123, 23);
            this.btnlReset.TabIndex = 1;
            this.btnlReset.Text = "Resetear";
            this.btnlReset.UseVisualStyleBackColor = true;
            this.btnlReset.Click += new System.EventHandler(this.btnlReset_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(14, 21);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(252, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAnguloInterno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAltura);
            this.groupBox1.Controls.Add(this.txtBase);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entras";
            // 
            // txtAnguloInterno
            // 
            this.txtAnguloInterno.Location = new System.Drawing.Point(143, 71);
            this.txtAnguloInterno.Name = "txtAnguloInterno";
            this.txtAnguloInterno.Size = new System.Drawing.Size(100, 22);
            this.txtAnguloInterno.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Angulo interior:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(143, 46);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 22);
            this.txtAltura.TabIndex = 3;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(143, 18);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 22);
            this.txtBase.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base:";
            // 
            // FrmRomboide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRomboide";
            this.Text = "FrmRomboide";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnAbajo;
        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.Button btnGiroAntiHorario;
        private System.Windows.Forms.Button btnGiroHorario;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnlReset;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnguloInterno;
        private System.Windows.Forms.Label label5;
    }
}