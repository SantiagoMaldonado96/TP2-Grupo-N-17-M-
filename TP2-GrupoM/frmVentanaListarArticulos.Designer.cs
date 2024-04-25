
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
            this.sstCantidadArticulos = new System.Windows.Forms.StatusStrip();
            this.stlblCantidadArticulos = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlblNumeroArticulos = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAgregarArt = new System.Windows.Forms.Button();
            this.btnModificarArt = new System.Windows.Forms.Button();
            this.btnEliminarArt = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dvgArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.sstCantidadArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
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
            // sstCantidadArticulos
            // 
            this.sstCantidadArticulos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlblCantidadArticulos,
            this.stlblNumeroArticulos});
            this.sstCantidadArticulos.Location = new System.Drawing.Point(0, 473);
            this.sstCantidadArticulos.Name = "sstCantidadArticulos";
            this.sstCantidadArticulos.Size = new System.Drawing.Size(978, 22);
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
            this.btnAgregarArt.Location = new System.Drawing.Point(24, 429);
            this.btnAgregarArt.Name = "btnAgregarArt";
            this.btnAgregarArt.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarArt.TabIndex = 1;
            this.btnAgregarArt.Text = "Agregar...";
            this.btnAgregarArt.UseVisualStyleBackColor = true;
            this.btnAgregarArt.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificarArt
            // 
            this.btnModificarArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificarArt.Location = new System.Drawing.Point(121, 429);
            this.btnModificarArt.Name = "btnModificarArt";
            this.btnModificarArt.Size = new System.Drawing.Size(75, 23);
            this.btnModificarArt.TabIndex = 2;
            this.btnModificarArt.Text = "Modificar...";
            this.btnModificarArt.UseVisualStyleBackColor = true;
            this.btnModificarArt.Click += new System.EventHandler(this.btnModificarArt_Click);
            // 
            // btnEliminarArt
            // 
            this.btnEliminarArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarArt.Location = new System.Drawing.Point(215, 429);
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
            this.btnSalir.Location = new System.Drawing.Point(866, 429);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dvgArticulos
            // 
            this.dvgArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgArticulos.Location = new System.Drawing.Point(26, 81);
            this.dvgArticulos.MultiSelect = false;
            this.dvgArticulos.Name = "dvgArticulos";
            this.dvgArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgArticulos.Size = new System.Drawing.Size(658, 326);
            this.dvgArticulos.TabIndex = 5;
            this.dvgArticulos.SelectionChanged += new System.EventHandler(this.dvgArticulos_SelectionChanged_1);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArticulo.Location = new System.Drawing.Point(690, 81);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(251, 326);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArticulo.TabIndex = 6;
            this.pbxArticulo.TabStop = false;
            // 
            // frmVentanaListarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 495);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dvgArticulos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarArt);
            this.Controls.Add(this.btnModificarArt);
            this.Controls.Add(this.btnAgregarArt);
            this.Controls.Add(this.sstCantidadArticulos);
            this.Controls.Add(this.lblTituloListadoArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVentanaListarArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Articulos";
            this.Load += new System.EventHandler(this.frmVentanaListarArticulos_Load);
            this.sstCantidadArticulos.ResumeLayout(false);
            this.sstCantidadArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
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
        private System.Windows.Forms.DataGridView dvgArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
    }
}