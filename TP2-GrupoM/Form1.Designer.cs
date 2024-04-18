namespace TP2_GrupoM
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(31, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(123, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CATALOGO";
            // 
            // btnArticulos
            // 
            this.btnArticulos.Location = new System.Drawing.Point(49, 89);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(75, 23);
            this.btnArticulos.TabIndex = 1;
            this.btnArticulos.Text = "Articulos";
            this.btnArticulos.UseVisualStyleBackColor = true;
            // 
            // btnMarcas
            // 
            this.btnMarcas.Location = new System.Drawing.Point(49, 136);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(75, 23);
            this.btnMarcas.TabIndex = 2;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(49, 183);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(75, 23);
            this.btnCategorias.TabIndex = 3;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 272);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.btnArticulos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnCategorias;
    }
}

