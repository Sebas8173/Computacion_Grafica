namespace Figuras
{
    partial class FrmTriangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTriangulo));
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.txtSideC = new System.Windows.Forms.TextBox();
            this.lblSideC = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblSideA = new System.Windows.Forms.Label();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbOutputs = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.grbInputs.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.grbOutputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtSideC);
            this.grbInputs.Controls.Add(this.lblSideC);
            this.grbInputs.Controls.Add(this.txtBase);
            this.grbInputs.Controls.Add(this.txtSideA);
            this.grbInputs.Controls.Add(this.lblBase);
            this.grbInputs.Controls.Add(this.lblSideA);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(19, 24);
            this.grbInputs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbInputs.Size = new System.Drawing.Size(327, 173);
            this.grbInputs.TabIndex = 7;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // txtSideC
            // 
            this.txtSideC.Location = new System.Drawing.Point(121, 124);
            this.txtSideC.Name = "txtSideC";
            this.txtSideC.Size = new System.Drawing.Size(112, 26);
            this.txtSideC.TabIndex = 1;
            // 
            // lblSideC
            // 
            this.lblSideC.AutoSize = true;
            this.lblSideC.Location = new System.Drawing.Point(25, 124);
            this.lblSideC.Name = "lblSideC";
            this.lblSideC.Size = new System.Drawing.Size(68, 20);
            this.lblSideC.TabIndex = 1;
            this.lblSideC.Text = "Lado c:";
            this.lblSideC.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(121, 81);
            this.txtBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(112, 26);
            this.txtBase.TabIndex = 3;
            // 
            // txtSideA
            // 
            this.txtSideA.Location = new System.Drawing.Point(121, 42);
            this.txtSideA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(112, 26);
            this.txtSideA.TabIndex = 2;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(25, 84);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(69, 20);
            this.lblBase.TabIndex = 1;
            this.lblBase.Text = "Lado b:";
            // 
            // lblSideA
            // 
            this.lblSideA.AutoSize = true;
            this.lblSideA.Location = new System.Drawing.Point(25, 45);
            this.lblSideA.Name = "lblSideA";
            this.lblSideA.Size = new System.Drawing.Size(69, 20);
            this.lblSideA.TabIndex = 0;
            this.lblSideA.Text = "Lado a:";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(19, 222);
            this.grbProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbProcess.Size = new System.Drawing.Size(327, 120);
            this.grbProcess.TabIndex = 8;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
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
            // grbOutputs
            // 
            this.grbOutputs.Controls.Add(this.txtArea);
            this.grbOutputs.Controls.Add(this.txtPerimeter);
            this.grbOutputs.Controls.Add(this.lblArea);
            this.grbOutputs.Controls.Add(this.lblPerimeter);
            this.grbOutputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOutputs.Location = new System.Drawing.Point(391, 93);
            this.grbOutputs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbOutputs.Size = new System.Drawing.Size(327, 189);
            this.grbOutputs.TabIndex = 9;
            this.grbOutputs.TabStop = false;
            this.grbOutputs.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(138, 116);
            this.txtArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(112, 26);
            this.txtArea.TabIndex = 3;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(138, 56);
            this.txtPerimeter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(112, 26);
            this.txtPerimeter.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(25, 116);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(47, 20);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Área";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(25, 56);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(86, 20);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perímetro";
            // 
            // FrmTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 364);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 420);
            this.MinimumSize = new System.Drawing.Size(800, 420);
            this.Name = "FrmTriangulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTriangulo";
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.Label lblSideC;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblSideA;
        private System.Windows.Forms.TextBox txtSideC;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbOutputs;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
    }
}