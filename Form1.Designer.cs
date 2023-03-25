namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lblRad = new System.Windows.Forms.Label();
            this.lblAlt = new System.Windows.Forms.Label();
            this.lblVol = new System.Windows.Forms.Label();
            this.txtBoxRad = new System.Windows.Forms.TextBox();
            this.txtBoxVol = new System.Windows.Forms.TextBox();
            this.txtBoxAlt = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRad
            // 
            this.lblRad.AutoSize = true;
            this.lblRad.Location = new System.Drawing.Point(69, 75);
            this.lblRad.Name = "lblRad";
            this.lblRad.Size = new System.Drawing.Size(29, 13);
            this.lblRad.TabIndex = 0;
            this.lblRad.Text = "Raio";
            this.lblRad.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblAlt
            // 
            this.lblAlt.AutoSize = true;
            this.lblAlt.Location = new System.Drawing.Point(69, 100);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(34, 13);
            this.lblAlt.TabIndex = 1;
            this.lblAlt.Text = "Altura";
            // 
            // lblVol
            // 
            this.lblVol.AutoSize = true;
            this.lblVol.Location = new System.Drawing.Point(69, 127);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(42, 13);
            this.lblVol.TabIndex = 2;
            this.lblVol.Text = "Volume";
            this.lblVol.Click += new System.EventHandler(this.Label3_Click);
            // 
            // txtBoxRad
            // 
            this.txtBoxRad.Location = new System.Drawing.Point(119, 72);
            this.txtBoxRad.Name = "txtBoxRad";
            this.txtBoxRad.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRad.TabIndex = 3;
            this.txtBoxRad.Validated += new System.EventHandler(this.TxtBoxRad_Validated);
            // 
            // txtBoxVol
            // 
            this.txtBoxVol.Enabled = false;
            this.txtBoxVol.Location = new System.Drawing.Point(119, 126);
            this.txtBoxVol.Name = "txtBoxVol";
            this.txtBoxVol.Size = new System.Drawing.Size(100, 20);
            this.txtBoxVol.TabIndex = 4;
            // 
            // txtBoxAlt
            // 
            this.txtBoxAlt.Location = new System.Drawing.Point(119, 100);
            this.txtBoxAlt.Name = "txtBoxAlt";
            this.txtBoxAlt.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAlt.TabIndex = 5;
            this.txtBoxAlt.Validated += new System.EventHandler(this.TxtBoxAlt_Validated);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(72, 217);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            this.btnCalc.Validated += new System.EventHandler(this.BtnCalc_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(153, 217);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "FECHAR";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtBoxAlt);
            this.Controls.Add(this.txtBoxVol);
            this.Controls.Add(this.txtBoxRad);
            this.Controls.Add(this.lblVol);
            this.Controls.Add(this.lblAlt);
            this.Controls.Add(this.lblRad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRad;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.Label lblVol;
        private System.Windows.Forms.TextBox txtBoxRad;
        private System.Windows.Forms.TextBox txtBoxVol;
        private System.Windows.Forms.TextBox txtBoxAlt;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClose;
    }
}

