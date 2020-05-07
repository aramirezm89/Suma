namespace Suma
{
    partial class Suma
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSuma = new System.Windows.Forms.Button();
            this.LblNum1 = new System.Windows.Forms.Label();
            this.TxtNum1 = new System.Windows.Forms.TextBox();
            this.TxtNum2 = new System.Windows.Forms.TextBox();
            this.LblNumero2 = new System.Windows.Forms.Label();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSuma
            // 
            this.BtnSuma.Location = new System.Drawing.Point(152, 277);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(75, 23);
            this.BtnSuma.TabIndex = 0;
            this.BtnSuma.Text = "Sumar";
            this.BtnSuma.UseVisualStyleBackColor = true;
            this.BtnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // LblNum1
            // 
            this.LblNum1.AutoSize = true;
            this.LblNum1.Location = new System.Drawing.Point(152, 122);
            this.LblNum1.Name = "LblNum1";
            this.LblNum1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblNum1.Size = new System.Drawing.Size(74, 17);
            this.LblNum1.TabIndex = 1;
            this.LblNum1.Text = "Numero 1:";
            // 
            // TxtNum1
            // 
            this.TxtNum1.Location = new System.Drawing.Point(424, 117);
            this.TxtNum1.Name = "TxtNum1";
            this.TxtNum1.Size = new System.Drawing.Size(100, 22);
            this.TxtNum1.TabIndex = 2;
            this.TxtNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNum1_KeyPress);
            // 
            // TxtNum2
            // 
            this.TxtNum2.Location = new System.Drawing.Point(424, 169);
            this.TxtNum2.Name = "TxtNum2";
            this.TxtNum2.Size = new System.Drawing.Size(100, 22);
            this.TxtNum2.TabIndex = 3;
            this.TxtNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNum2_KeyPress);
            // 
            // LblNumero2
            // 
            this.LblNumero2.AutoSize = true;
            this.LblNumero2.Location = new System.Drawing.Point(152, 169);
            this.LblNumero2.Name = "LblNumero2";
            this.LblNumero2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblNumero2.Size = new System.Drawing.Size(74, 17);
            this.LblNumero2.TabIndex = 4;
            this.LblNumero2.Text = "Numero 2:";
            // 
            // TxtResult
            // 
            this.TxtResult.Enabled = false;
            this.TxtResult.Location = new System.Drawing.Point(424, 266);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(100, 22);
            this.TxtResult.TabIndex = 5;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(152, 339);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseMnemonic = false;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Suma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.LblNumero2);
            this.Controls.Add(this.TxtNum2);
            this.Controls.Add(this.TxtNum1);
            this.Controls.Add(this.LblNum1);
            this.Controls.Add(this.BtnSuma);
            this.Name = "Suma";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Label LblNum1;
        private System.Windows.Forms.TextBox TxtNum1;
        private System.Windows.Forms.TextBox TxtNum2;
        private System.Windows.Forms.Label LblNumero2;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Button BtnSalir;
    }
}

