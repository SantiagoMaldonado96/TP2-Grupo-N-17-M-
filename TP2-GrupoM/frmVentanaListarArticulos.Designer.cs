
namespace TP2_GrupoM
{
    partial class frmVentanaListarArticulos
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
            this.lblTituloListadoArticulos = new System.Windows.Forms.Label();
            this.lwArticulos = new System.Windows.Forms.ListView();
            this.CodigoArt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreArt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescripcionArt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MarcaArt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CategoriaArt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrecioArt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sstCantidadArticulos = new System.Windows.Forms.StatusStrip();
            this.stlblCantidadArticulos = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlblNumeroArticulos = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAgregarArt = new System.Windows.Forms.Button();
            this.btnModificarArt = new System.Windows.Forms.Button();
            this.btnEliminarArt = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.urlImagenArt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sstCantidadArticulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloListadoArticulos
            // 
            this.lblTituloListadoArticulos.AutoSize = true;
            this.lblTituloListadoArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloListadoArticulos.Location = new System.Drawing.Point(19, 18);
            this.lblTituloListadoArticulos.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTituloListadoArticulos.Name = "lblTituloListadoArticulos";
            this.lblTituloListadoArticulos.Size = new System.Drawing.Size(315, 37);
            this.lblTituloListadoArticulos.TabIndex = 0;
            this.lblTituloListadoArticulos.Text = "Articulos Disponibles";
            this.lblTituloListadoArticulos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lwArticulos
            // 
            this.lwArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwArticulos.BackColor = System.Drawing.SystemColors.Info;
            this.lwArticulos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodigoArt,
            this.NombreArt,
            this.DescripcionArt,
            this.MarcaArt,
            this.CategoriaArt,
            this.PrecioArt,
            this.urlImagenArt});
            this.lwArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lwArticulos.FullRowSelect = true;
            this.lwArticulos.GridLines = true;
            this.lwArticulos.HideSelection = false;
            this.lwArticulos.Location = new System.Drawing.Point(26, 81);
            this.lwArticulos.Name = "lwArticulos";
            this.lwArticulos.Size = new System.Drawing.Size(645, 288);
            this.lwArticulos.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lwArticulos.TabIndex = 1;
            this.lwArticulos.UseCompatibleStateImageBehavior = false;
            this.lwArticulos.View = System.Windows.Forms.View.Details;
            this.lwArticulos.SelectedIndexChanged += new System.EventHandler(this.lwArticulos_SelectedIndexChanged);
            // 
            // CodigoArt
            // 
            this.CodigoArt.Text = "Codigo";
            this.CodigoArt.Width = 50;
            // 
            // NombreArt
            // 
            this.NombreArt.Text = "Nombre";
            this.NombreArt.Width = 70;
            // 
            // DescripcionArt
            // 
            this.DescripcionArt.Text = "Descripcion";
            this.DescripcionArt.Width = 106;
            // 
            // MarcaArt
            // 
            this.MarcaArt.Text = "Marca";
            this.MarcaArt.Width = 87;
            // 
            // CategoriaArt
            // 
            this.CategoriaArt.Text = "Categoria";
            this.CategoriaArt.Width = 180;
            // 
            // PrecioArt
            // 
            this.PrecioArt.Text = "Precio";
            this.PrecioArt.Width = 55;
            // 
            // sstCantidadArticulos
            // 
            this.sstCantidadArticulos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlblCantidadArticulos,
            this.stlblNumeroArticulos});
            this.sstCantidadArticulos.Location = new System.Drawing.Point(0, 436);
            this.sstCantidadArticulos.Name = "sstCantidadArticulos";
            this.sstCantidadArticulos.Size = new System.Drawing.Size(708, 22);
            this.sstCantidadArticulos.TabIndex = 2;
            this.sstCantidadArticulos.Text = "statusStrip1";
            // 
            // stlblCantidadArticulos
            // 
            this.stlblCantidadArticulos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.stlblCantidadArticulos.Name = "stlblCantidadArticulos";
            this.stlblCantidadArticulos.Size = new System.Drawing.Size(183, 17);
            this.stlblCantidadArticulos.Text = "Cantidad de Articulos Cargados: ";
            // 
            // stlblNumeroArticulos
            // 
            this.stlblNumeroArticulos.Name = "stlblNumeroArticulos";
            this.stlblNumeroArticulos.Size = new System.Drawing.Size(174, 17);
            this.stlblNumeroArticulos.Text = "\"Cantidad de Art. en el sistema\"";
            // 
            // btnAgregarArt
            // 
            this.btnAgregarArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarArt.Location = new System.Drawing.Point(24, 392);
            this.btnAgregarArt.Name = "btnAgregarArt";
            this.btnAgregarArt.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarArt.TabIndex = 3;
            this.btnAgregarArt.Text = "Agregar...";
            this.btnAgregarArt.UseVisualStyleBackColor = true;
            this.btnAgregarArt.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificarArt
            // 
            this.btnModificarArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificarArt.Location = new System.Drawing.Point(121, 392);
            this.btnModificarArt.Name = "btnModificarArt";
            this.btnModificarArt.Size = new System.Drawing.Size(75, 23);
            this.btnModificarArt.TabIndex = 3;
            this.btnModificarArt.Text = "Modificar...";
            this.btnModificarArt.UseVisualStyleBackColor = true;
            this.btnModificarArt.Click += new System.EventHandler(this.btnModificarArt_Click);
            // 
            // btnEliminarArt
            // 
            this.btnEliminarArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarArt.Location = new System.Drawing.Point(215, 392);
            this.btnEliminarArt.Name = "btnEliminarArt";
            this.btnEliminarArt.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarArt.TabIndex = 3;
            this.btnEliminarArt.Text = "Eliminar...";
            this.btnEliminarArt.UseVisualStyleBackColor = true;
            this.btnEliminarArt.Click += new System.EventHandler(this.btnEliminarArt_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(596, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // urlImagenArt
            // 
            this.urlImagenArt.Text = "URL Imagen";
            this.urlImagenArt.Width = 104;
            // 
            // frmVentanaListarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 458);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarArt);
            this.Controls.Add(this.btnModificarArt);
            this.Controls.Add(this.btnAgregarArt);
            this.Controls.Add(this.sstCantidadArticulos);
            this.Controls.Add(this.lwArticulos);
            this.Controls.Add(this.lblTituloListadoArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVentanaListarArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Articulos";
            this.sstCantidadArticulos.ResumeLayout(false);
            this.sstCantidadArticulos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloListadoArticulos;
        private System.Windows.Forms.StatusStrip sstCantidadArticulos;
        private System.Windows.Forms.ToolStripStatusLabel stlblCantidadArticulos;
        private System.Windows.Forms.ToolStripStatusLabel stlblNumeroArticulos;
        private System.Windows.Forms.Button btnAgregarArt;
        private System.Windows.Forms.Button btnModificarArt;
        private System.Windows.Forms.Button btnEliminarArt;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ColumnHeader CodigoArt;
        private System.Windows.Forms.ColumnHeader NombreArt;
        private System.Windows.Forms.ColumnHeader DescripcionArt;
        private System.Windows.Forms.ColumnHeader MarcaArt;
        private System.Windows.Forms.ColumnHeader CategoriaArt;
        private System.Windows.Forms.ColumnHeader PrecioArt;
        public System.Windows.Forms.ListView lwArticulos;
        private System.Windows.Forms.ColumnHeader urlImagenArt;
    }
}