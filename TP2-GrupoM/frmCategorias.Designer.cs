namespace TP2_GrupoM
{
    partial class frmCategorias
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
            this.btnBuscarCat = new System.Windows.Forms.Button();
            this.btnListarCat = new System.Windows.Forms.Button();
            this.btnEliminarCat = new System.Windows.Forms.Button();
            this.btnModificarCat = new System.Windows.Forms.Button();
            this.btnAgregarCat = new System.Windows.Forms.Button();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscarCat
            // 
            this.btnBuscarCat.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnBuscarCat.Location = new System.Drawing.Point(156, 184);
            this.btnBuscarCat.Name = "btnBuscarCat";
            this.btnBuscarCat.Size = new System.Drawing.Size(143, 30);
            this.btnBuscarCat.TabIndex = 11;
            this.btnBuscarCat.Text = "Buscar Categoria";
            this.btnBuscarCat.UseVisualStyleBackColor = true;
            this.btnBuscarCat.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnListarCat
            // 
            this.btnListarCat.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnListarCat.Location = new System.Drawing.Point(156, 136);
            this.btnListarCat.Name = "btnListarCat";
            this.btnListarCat.Size = new System.Drawing.Size(143, 30);
            this.btnListarCat.TabIndex = 10;
            this.btnListarCat.Text = "Listar Categorias";
            this.btnListarCat.UseVisualStyleBackColor = true;
            this.btnListarCat.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnEliminarCat.Location = new System.Drawing.Point(156, 333);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(143, 30);
            this.btnEliminarCat.TabIndex = 9;
            this.btnEliminarCat.Text = "Eliminar Categoria";
            this.btnEliminarCat.UseVisualStyleBackColor = true;
            this.btnEliminarCat.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificarCat
            // 
            this.btnModificarCat.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnModificarCat.Location = new System.Drawing.Point(156, 283);
            this.btnModificarCat.Name = "btnModificarCat";
            this.btnModificarCat.Size = new System.Drawing.Size(143, 30);
            this.btnModificarCat.TabIndex = 8;
            this.btnModificarCat.Text = "Modificar Categoria";
            this.btnModificarCat.UseVisualStyleBackColor = true;
            this.btnModificarCat.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregarCat
            // 
            this.btnAgregarCat.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCat.Location = new System.Drawing.Point(156, 233);
            this.btnAgregarCat.Name = "btnAgregarCat";
            this.btnAgregarCat.Size = new System.Drawing.Size(143, 30);
            this.btnAgregarCat.TabIndex = 7;
            this.btnAgregarCat.Text = "Agregar Categoria";
            this.btnAgregarCat.UseVisualStyleBackColor = true;
            this.btnAgregarCat.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.Location = new System.Drawing.Point(131, 58);
            this.lblCategorias.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(188, 40);
            this.lblCategorias.TabIndex = 6;
            this.lblCategorias.Text = "Categorias";
            this.lblCategorias.Click += new System.EventHandler(this.lblArticulos_Click);
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 446);
            this.Controls.Add(this.btnBuscarCat);
            this.Controls.Add(this.btnListarCat);
            this.Controls.Add(this.btnEliminarCat);
            this.Controls.Add(this.btnModificarCat);
            this.Controls.Add(this.btnAgregarCat);
            this.Controls.Add(this.lblCategorias);
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCategorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarCat;
        private System.Windows.Forms.Button btnListarCat;
        private System.Windows.Forms.Button btnEliminarCat;
        private System.Windows.Forms.Button btnModificarCat;
        private System.Windows.Forms.Button btnAgregarCat;
        private System.Windows.Forms.Label lblCategorias;
    }
}