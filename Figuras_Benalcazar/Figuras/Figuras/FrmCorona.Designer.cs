namespace Figuras
{
    partial class FrmCorona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCorona));
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.txtRadioI = new System.Windows.Forms.TextBox();
            this.txtRadioE = new System.Windows.Forms.TextBox();
            this.lblRadioI = new System.Windows.Forms.Label();
            this.lblRadioE = new System.Windows.Forms.Label();
            this.grbOutputs = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.grbInputs.SuspendLayout();
            this.grbOutputs.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtRadioI);
            this.grbInputs.Controls.Add(this.txtRadioE);
            this.grbInputs.Controls.Add(this.lblRadioI);
            this.grbInputs.Controls.Add(this.lblRadioE);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(40, 25);
            this.grbInputs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbInputs.Size = new System.Drawing.Size(327, 154);
            this.grbInputs.TabIndex = 2;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // txtRadioI
            // 
            this.txtRadioI.Location = new System.Drawing.Point(163, 90);
            this.txtRadioI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRadioI.Name = "txtRadioI";
            this.txtRadioI.Size = new System.Drawing.Size(112, 20);
            this.txtRadioI.TabIndex = 3;
            // 
            // txtRadioE
            // 
            this.txtRadioE.Location = new System.Drawing.Point(163, 42);
            this.txtRadioE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRadioE.Name = "txtRadioE";
            this.txtRadioE.Size = new System.Drawing.Size(112, 20);
            this.txtRadioE.TabIndex = 2;
            // 
            // lblRadioI
            // 
            this.lblRadioI.AutoSize = true;
            this.lblRadioI.Location = new System.Drawing.Point(25, 90);
            this.lblRadioI.Name = "lblRadioI";
            this.lblRadioI.Size = new System.Drawing.Size(84, 13);
            this.lblRadioI.TabIndex = 1;
            this.lblRadioI.Text = "Radio Interno";
            // 
            // lblRadioE
            // 
            this.lblRadioE.AutoSize = true;
            this.lblRadioE.Location = new System.Drawing.Point(25, 45);
            this.lblRadioE.Name = "lblRadioE";
            this.lblRadioE.Size = new System.Drawing.Size(87, 13);
            this.lblRadioE.TabIndex = 0;
            this.lblRadioE.Text = "Radio Externo";
            // 
            // grbOutputs
            // 
            this.grbOutputs.Controls.Add(this.txtArea);
            this.grbOutputs.Controls.Add(this.lblArea);
            this.grbOutputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOutputs.Location = new System.Drawing.Point(417, 136);
            this.grbOutputs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbOutputs.Size = new System.Drawing.Size(327, 120);
            this.grbOutputs.TabIndex = 7;
            this.grbOutputs.TabStop = false;
            this.grbOutputs.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(163, 60);
            this.txtArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(112, 20);
            this.txtArea.TabIndex = 3;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(58, 66);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(33, 13);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Área";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(7, 56);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(98, 29);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(111, 56);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 29);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(226, 56);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(40, 216);
            this.grbProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbProcess.Size = new System.Drawing.Size(327, 120);
            this.grbProcess.TabIndex = 8;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            // 
            // FrmCorona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 571);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbInputs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 420);
            this.MinimumSize = new System.Drawing.Size(800, 420);
            this.Name = "FrmCorona";
            this.Text = "FrmCorona";
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtRadioI;
        private System.Windows.Forms.TextBox txtRadioE;
        private System.Windows.Forms.Label lblRadioI;
        private System.Windows.Forms.Label lblRadioE;
        private System.Windows.Forms.GroupBox grbOutputs;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grbProcess;
    }
}