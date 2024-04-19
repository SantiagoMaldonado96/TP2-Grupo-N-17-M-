namespace TP2_GrupoM
{
    partial class frmMarcas
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
            this.btnBuscarMarca = new System.Windows.Forms.Button();
            this.btnListarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscarMarca
            // 
            this.btnBuscarMarca.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnBuscarMarca.Location = new System.Drawing.Point(152, 185);
            this.btnBuscarMarca.Name = "btnBuscarMarca";
            this.btnBuscarMarca.Size = new System.Drawing.Size(143, 30);
            this.btnBuscarMarca.TabIndex = 17;
            this.btnBuscarMarca.Text = "Buscar Marca";
            this.btnBuscarMarca.UseVisualStyleBackColor = true;
            // 
            // btnListarMarca
            // 
            this.btnListarMarca.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnListarMarca.Location = new System.Drawing.Point(152, 137);
            this.btnListarMarca.Name = "btnListarMarca";
            this.btnListarMarca.Size = new System.Drawing.Size(143, 30);
            this.btnListarMarca.TabIndex = 16;
            this.btnListarMarca.Text = "Listar Marcas";
            this.btnListarMarca.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnEliminarMarca.Location = new System.Drawing.Point(152, 334);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(143, 30);
            this.btnEliminarMarca.TabIndex = 15;
            this.btnEliminarMarca.Text = "Eliminar Marca";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnModificarMarca.Location = new System.Drawing.Point(152, 284);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(143, 30);
            this.btnModificarMarca.TabIndex = 14;
            this.btnModificarMarca.Text = "Modificar Marca";
            this.btnModificarMarca.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarca.Location = new System.Drawing.Point(152, 234);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(143, 30);
            this.btnAgregarMarca.TabIndex = 13;
            this.btnAgregarMarca.Text = "Agregar Marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.Location = new System.Drawing.Point(160, 59);
            this.lblMarcas.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(130, 40);
            this.lblMarcas.TabIndex = 12;
            this.lblMarcas.Text = "Marcas";
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 446);
            this.Controls.Add(this.btnBuscarMarca);
            this.Controls.Add(this.btnListarMarca);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnModificarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.lblMarcas);
            this.Name = "frmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMarcas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarMarca;
        private System.Windows.Forms.Button btnListarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Label lblMarcas;
    }
}