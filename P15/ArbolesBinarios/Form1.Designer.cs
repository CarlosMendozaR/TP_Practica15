namespace ArbolesBinarios
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbDato = new System.Windows.Forms.TextBox();
            this.ptbArbol = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbArbol)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa dato";
            // 
            // txtbDato
            // 
            this.txtbDato.Location = new System.Drawing.Point(149, 51);
            this.txtbDato.Name = "txtbDato";
            this.txtbDato.Size = new System.Drawing.Size(100, 22);
            this.txtbDato.TabIndex = 1;
            this.txtbDato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbDato_KeyPress);
            // 
            // ptbArbol
            // 
            this.ptbArbol.Location = new System.Drawing.Point(23, 116);
            this.ptbArbol.Name = "ptbArbol";
            this.ptbArbol.Size = new System.Drawing.Size(930, 557);
            this.ptbArbol.TabIndex = 2;
            this.ptbArbol.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 700);
            this.Controls.Add(this.ptbArbol);
            this.Controls.Add(this.txtbDato);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbArbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbDato;
        private System.Windows.Forms.PictureBox ptbArbol;
    }
}

