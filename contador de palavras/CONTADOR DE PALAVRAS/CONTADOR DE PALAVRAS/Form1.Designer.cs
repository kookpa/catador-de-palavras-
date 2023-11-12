namespace CONTADOR_DE_PALAVRAS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbTexto = new System.Windows.Forms.TextBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbTexto
            // 
            this.txbTexto.Location = new System.Drawing.Point(65, 55);
            this.txbTexto.Name = "txbTexto";
            this.txbTexto.Size = new System.Drawing.Size(124, 20);
            this.txbTexto.TabIndex = 0;
            this.txbTexto.TextChanged += new System.EventHandler(this.txbTexto_TextChanged);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(86, 102);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(0, 13);
            this.lblContador.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.txbTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbTexto;
        private System.Windows.Forms.Label lblContador;
    }
}

