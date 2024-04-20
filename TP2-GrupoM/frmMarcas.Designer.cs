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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.lwMarcas = new System.Windows.Forms.ListView();
            this.lblListadoMarcas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(603, 394);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarMarca.Location = new System.Drawing.Point(222, 394);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMarca.TabIndex = 7;
            this.btnEliminarMarca.Text = "Eliminar...";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificarMarca.Location = new System.Drawing.Point(128, 394);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnModificarMarca.TabIndex = 8;
            this.btnModificarMarca.Text = "Modificar...";
            this.btnModificarMarca.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarMarca.Location = new System.Drawing.Point(31, 394);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMarca.TabIndex = 9;
            this.btnAgregarMarca.Text = "Agregar...";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // lwMarcas
            // 
            this.lwMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwMarcas.BackColor = System.Drawing.SystemColors.Info;
            this.lwMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lwMarcas.HideSelection = false;
            this.lwMarcas.Location = new System.Drawing.Point(33, 76);
            this.lwMarcas.Name = "lwMarcas";
            this.lwMarcas.Size = new System.Drawing.Size(642, 295);
            this.lwMarcas.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lwMarcas.TabIndex = 6;
            this.lwMarcas.UseCompatibleStateImageBehavior = false;
            // 
            // lblListadoMarcas
            // 
            this.lblListadoMarcas.AutoSize = true;
            this.lblListadoMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoMarcas.Location = new System.Drawing.Point(26, 13);
            this.lblListadoMarcas.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblListadoMarcas.Name = "lblListadoMarcas";
            this.lblListadoMarcas.Size = new System.Drawing.Size(296, 37);
            this.lblListadoMarcas.TabIndex = 5;
            this.lblListadoMarcas.Text = "Marcas Disponibles";
            this.lblListadoMarcas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnModificarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.lwMarcas);
            this.Controls.Add(this.lblListadoMarcas);
            this.Name = "frmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMarcas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.ListView lwMarcas;
        private System.Windows.Forms.Label lblListadoMarcas;
    }
}