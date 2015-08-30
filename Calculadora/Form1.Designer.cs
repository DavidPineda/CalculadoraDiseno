namespace Calculos
{
    partial class frmMultiplicacion
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
            this.txtMultiplicando = new System.Windows.Forms.TextBox();
            this.txtMultiplicador = new System.Windows.Forms.TextBox();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.lblMultiplicando = new System.Windows.Forms.Label();
            this.lblMultiplicador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMultiplicando
            // 
            this.txtMultiplicando.Location = new System.Drawing.Point(143, 13);
            this.txtMultiplicando.MaxLength = 10;
            this.txtMultiplicando.Name = "txtMultiplicando";
            this.txtMultiplicando.Size = new System.Drawing.Size(100, 20);
            this.txtMultiplicando.TabIndex = 0;
            // 
            // txtMultiplicador
            // 
            this.txtMultiplicador.Location = new System.Drawing.Point(143, 39);
            this.txtMultiplicador.MaxLength = 10;
            this.txtMultiplicador.Name = "txtMultiplicador";
            this.txtMultiplicador.Size = new System.Drawing.Size(100, 20);
            this.txtMultiplicador.TabIndex = 1;
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(167, 66);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicar.TabIndex = 2;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // lblMultiplicando
            // 
            this.lblMultiplicando.AutoSize = true;
            this.lblMultiplicando.CausesValidation = false;
            this.lblMultiplicando.Location = new System.Drawing.Point(67, 19);
            this.lblMultiplicando.Name = "lblMultiplicando";
            this.lblMultiplicando.Size = new System.Drawing.Size(69, 13);
            this.lblMultiplicando.TabIndex = 3;
            this.lblMultiplicando.Text = "Multiplicando";
            // 
            // lblMultiplicador
            // 
            this.lblMultiplicador.AutoSize = true;
            this.lblMultiplicador.Location = new System.Drawing.Point(70, 45);
            this.lblMultiplicador.Name = "lblMultiplicador";
            this.lblMultiplicador.Size = new System.Drawing.Size(66, 13);
            this.lblMultiplicador.TabIndex = 4;
            this.lblMultiplicador.Text = "Multiplicador";
            // 
            // frmMultiplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 350);
            this.Controls.Add(this.lblMultiplicador);
            this.Controls.Add(this.lblMultiplicando);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.txtMultiplicador);
            this.Controls.Add(this.txtMultiplicando);
            this.Name = "frmMultiplicacion";
            this.Text = "Multiplicacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMultiplicando;
        private System.Windows.Forms.TextBox txtMultiplicador;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Label lblMultiplicando;
        private System.Windows.Forms.Label lblMultiplicador;
    }
}

