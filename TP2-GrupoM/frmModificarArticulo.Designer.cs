
namespace TP2_GrupoM
{
    partial class frmModificarArticulo
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
            this.txbCodigoArt = new System.Windows.Forms.TextBox();
            this.btnCancelarAgregar = new System.Windows.Forms.Button();
            this.btnAgregarArt = new System.Windows.Forms.Button();
            this.cboCatArt = new System.Windows.Forms.ComboBox();
            this.cboMarcaArt = new System.Windows.Forms.ComboBox();
            this.txbDescArt = new System.Windows.Forms.TextBox();
            this.txbNombreArt = new System.Windows.Forms.TextBox();
            this.txbUrlImagen = new System.Windows.Forms.TextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.lblLinkImagen = new System.Windows.Forms.Label();
            this.lblPrecioArt = new System.Windows.Forms.Label();
            this.lblCatArt = new System.Windows.Forms.Label();
            this.lblMarcaArt = new System.Windows.Forms.Label();
            this.lblDescArt = new System.Windows.Forms.Label();
            this.lblCodArt = new System.Windows.Forms.Label();
            this.lblNombreArt = new System.Windows.Forms.Label();
            this.lblTituloModificar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbCodigoArt
            // 
            this.txbCodigoArt.Location = new System.Drawing.Point(177, 137);
            this.txbCodigoArt.Name = "txbCodigoArt";
            this.txbCodigoArt.Size = new System.Drawing.Size(100, 20);
            this.txbCodigoArt.TabIndex = 9;
            // 
            // btnCancelarAgregar
            // 
            this.btnCancelarAgregar.Location = new System.Drawing.Point(225, 363);
            this.btnCancelarAgregar.Name = "btnCancelarAgregar";
            this.btnCancelarAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAgregar.TabIndex = 25;
            this.btnCancelarAgregar.Text = "Cancelar";
            this.btnCancelarAgregar.UseVisualStyleBackColor = true;
            this.btnCancelarAgregar.Click += new System.EventHandler(this.btnCancelarAgregar_Click);
            // 
            // btnAgregarArt
            // 
            this.btnAgregarArt.Location = new System.Drawing.Point(134, 363);
            this.btnAgregarArt.Name = "btnAgregarArt";
            this.btnAgregarArt.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarArt.TabIndex = 24;
            this.btnAgregarArt.Text = "Aceptar";
            this.btnAgregarArt.UseVisualStyleBackColor = true;
            this.btnAgregarArt.Click += new System.EventHandler(this.btnAgregarArt_Click);
            // 
            // cboCatArt
            // 
            this.cboCatArt.FormattingEnabled = true;
            this.cboCatArt.Location = new System.Drawing.Point(177, 255);
            this.cboCatArt.Name = "cboCatArt";
            this.cboCatArt.Size = new System.Drawing.Size(100, 21);
            this.cboCatArt.TabIndex = 21;
            // 
            // cboMarcaArt
            // 
            this.cboMarcaArt.FormattingEnabled = true;
            this.cboMarcaArt.Location = new System.Drawing.Point(177, 226);
            this.cboMarcaArt.Name = "cboMarcaArt";
            this.cboMarcaArt.Size = new System.Drawing.Size(100, 21);
            this.cboMarcaArt.TabIndex = 20;
            // 
            // txbDescArt
            // 
            this.txbDescArt.Location = new System.Drawing.Point(177, 198);
            this.txbDescArt.Name = "txbDescArt";
            this.txbDescArt.Size = new System.Drawing.Size(100, 20);
            this.txbDescArt.TabIndex = 19;
            // 
            // txbNombreArt
            // 
            this.txbNombreArt.Location = new System.Drawing.Point(177, 167);
            this.txbNombreArt.Name = "txbNombreArt";
            this.txbNombreArt.Size = new System.Drawing.Size(100, 20);
            this.txbNombreArt.TabIndex = 11;
            // 
            // txbUrlImagen
            // 
            this.txbUrlImagen.Location = new System.Drawing.Point(177, 317);
            this.txbUrlImagen.Name = "txbUrlImagen";
            this.txbUrlImagen.Size = new System.Drawing.Size(100, 20);
            this.txbUrlImagen.TabIndex = 23;
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(177, 285);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(100, 20);
            this.txbPrecio.TabIndex = 22;
            // 
            // lblLinkImagen
            // 
            this.lblLinkImagen.AutoSize = true;
            this.lblLinkImagen.Location = new System.Drawing.Point(103, 320);
            this.lblLinkImagen.Name = "lblLinkImagen";
            this.lblLinkImagen.Size = new System.Drawing.Size(69, 13);
            this.lblLinkImagen.TabIndex = 13;
            this.lblLinkImagen.Text = "URL imagen:";
            // 
            // lblPrecioArt
            // 
            this.lblPrecioArt.AutoSize = true;
            this.lblPrecioArt.Location = new System.Drawing.Point(131, 290);
            this.lblPrecioArt.Name = "lblPrecioArt";
            this.lblPrecioArt.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioArt.TabIndex = 14;
            this.lblPrecioArt.Text = "Precio:";
            // 
            // lblCatArt
            // 
            this.lblCatArt.AutoSize = true;
            this.lblCatArt.Location = new System.Drawing.Point(116, 261);
            this.lblCatArt.Name = "lblCatArt";
            this.lblCatArt.Size = new System.Drawing.Size(55, 13);
            this.lblCatArt.TabIndex = 15;
            this.lblCatArt.Text = "Categoria:";
            // 
            // lblMarcaArt
            // 
            this.lblMarcaArt.AutoSize = true;
            this.lblMarcaArt.Location = new System.Drawing.Point(131, 232);
            this.lblMarcaArt.Name = "lblMarcaArt";
            this.lblMarcaArt.Size = new System.Drawing.Size(40, 13);
            this.lblMarcaArt.TabIndex = 16;
            this.lblMarcaArt.Text = "Marca:";
            // 
            // lblDescArt
            // 
            this.lblDescArt.AutoSize = true;
            this.lblDescArt.Location = new System.Drawing.Point(106, 202);
            this.lblDescArt.Name = "lblDescArt";
            this.lblDescArt.Size = new System.Drawing.Size(66, 13);
            this.lblDescArt.TabIndex = 17;
            this.lblDescArt.Text = "Descripcion:";
            // 
            // lblCodArt
            // 
            this.lblCodArt.AutoSize = true;
            this.lblCodArt.Location = new System.Drawing.Point(128, 140);
            this.lblCodArt.Name = "lblCodArt";
            this.lblCodArt.Size = new System.Drawing.Size(43, 13);
            this.lblCodArt.TabIndex = 18;
            this.lblCodArt.Text = "Codigo:";
            // 
            // lblNombreArt
            // 
            this.lblNombreArt.AutoSize = true;
            this.lblNombreArt.Location = new System.Drawing.Point(124, 170);
            this.lblNombreArt.Name = "lblNombreArt";
            this.lblNombreArt.Size = new System.Drawing.Size(47, 13);
            this.lblNombreArt.TabIndex = 12;
            this.lblNombreArt.Text = "Nombre:";
            // 
            // lblTituloModificar
            // 
            this.lblTituloModificar.AutoSize = true;
            this.lblTituloModificar.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloModificar.Location = new System.Drawing.Point(65, 35);
            this.lblTituloModificar.Name = "lblTituloModificar";
            this.lblTituloModificar.Size = new System.Drawing.Size(311, 40);
            this.lblTituloModificar.TabIndex = 10;
            this.lblTituloModificar.Text = "Modificar articulo";
            // 
            // frmModificarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 446);
            this.Controls.Add(this.txbCodigoArt);
            this.Controls.Add(this.btnCancelarAgregar);
            this.Controls.Add(this.btnAgregarArt);
            this.Controls.Add(this.cboCatArt);
            this.Controls.Add(this.cboMarcaArt);
            this.Controls.Add(this.txbDescArt);
            this.Controls.Add(this.txbNombreArt);
            this.Controls.Add(this.txbUrlImagen);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.lblLinkImagen);
            this.Controls.Add(this.lblPrecioArt);
            this.Controls.Add(this.lblCatArt);
            this.Controls.Add(this.lblMarcaArt);
            this.Controls.Add(this.lblDescArt);
            this.Controls.Add(this.lblCodArt);
            this.Controls.Add(this.lblNombreArt);
            this.Controls.Add(this.lblTituloModificar);
            this.Name = "frmModificarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModificarArticulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelarAgregar;
        public System.Windows.Forms.Button btnAgregarArt;
        private System.Windows.Forms.Label lblLinkImagen;
        private System.Windows.Forms.Label lblPrecioArt;
        private System.Windows.Forms.Label lblCatArt;
        private System.Windows.Forms.Label lblMarcaArt;
        private System.Windows.Forms.Label lblDescArt;
        private System.Windows.Forms.Label lblCodArt;
        private System.Windows.Forms.Label lblNombreArt;
        private System.Windows.Forms.Label lblTituloModificar;
        public System.Windows.Forms.TextBox txbCodigoArt;
        public System.Windows.Forms.ComboBox cboCatArt;
        public System.Windows.Forms.ComboBox cboMarcaArt;
        public System.Windows.Forms.TextBox txbDescArt;
        public System.Windows.Forms.TextBox txbNombreArt;
        public System.Windows.Forms.TextBox txbUrlImagen;
        public System.Windows.Forms.TextBox txbPrecio;
    }
}