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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarCat = new System.Windows.Forms.Button();
            this.btnModificarCat = new System.Windows.Forms.Button();
            this.btnAgregarCat = new System.Windows.Forms.Button();
            this.lwCategorias = new System.Windows.Forms.ListView();
            this.lblListadoCategorias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(583, 428);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarCat.Location = new System.Drawing.Point(226, 428);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCat.TabIndex = 7;
            this.btnEliminarCat.Text = "Eliminar...";
            this.btnEliminarCat.UseVisualStyleBackColor = true;
            // 
            // btnModificarCat
            // 
            this.btnModificarCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificarCat.Location = new System.Drawing.Point(132, 428);
            this.btnModificarCat.Name = "btnModificarCat";
            this.btnModificarCat.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCat.TabIndex = 8;
            this.btnModificarCat.Text = "Modificar...";
            this.btnModificarCat.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCat
            // 
            this.btnAgregarCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarCat.Location = new System.Drawing.Point(35, 428);
            this.btnAgregarCat.Name = "btnAgregarCat";
            this.btnAgregarCat.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCat.TabIndex = 9;
            this.btnAgregarCat.Text = "Agregar...";
            this.btnAgregarCat.UseVisualStyleBackColor = true;
            this.btnAgregarCat.Click += new System.EventHandler(this.btnAgregarCat_Click);
            // 
            // lwCategorias
            // 
            this.lwCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwCategorias.BackColor = System.Drawing.SystemColors.Info;
            this.lwCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lwCategorias.HideSelection = false;
            this.lwCategorias.Location = new System.Drawing.Point(37, 82);
            this.lwCategorias.Name = "lwCategorias";
            this.lwCategorias.Size = new System.Drawing.Size(621, 323);
            this.lwCategorias.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lwCategorias.TabIndex = 6;
            this.lwCategorias.UseCompatibleStateImageBehavior = false;
            // 
            // lblListadoCategorias
            // 
            this.lblListadoCategorias.AutoSize = true;
            this.lblListadoCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoCategorias.Location = new System.Drawing.Point(30, 19);
            this.lblListadoCategorias.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblListadoCategorias.Name = "lblListadoCategorias";
            this.lblListadoCategorias.Size = new System.Drawing.Size(346, 37);
            this.lblListadoCategorias.TabIndex = 5;
            this.lblListadoCategorias.Text = "Categorias Disponibles";
            this.lblListadoCategorias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 485);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarCat);
            this.Controls.Add(this.btnModificarCat);
            this.Controls.Add(this.btnAgregarCat);
            this.Controls.Add(this.lwCategorias);
            this.Controls.Add(this.lblListadoCategorias);
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCategorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarCat;
        private System.Windows.Forms.Button btnModificarCat;
        private System.Windows.Forms.Button btnAgregarCat;
        private System.Windows.Forms.ListView lwCategorias;
        private System.Windows.Forms.Label lblListadoCategorias;
    }
}