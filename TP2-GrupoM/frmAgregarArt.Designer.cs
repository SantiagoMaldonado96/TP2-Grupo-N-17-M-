namespace TP2_GrupoM
{
    partial class frmAgregarArt
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
            this.lblAgregar = new System.Windows.Forms.Label();
            this.lblNombreArt = new System.Windows.Forms.Label();
            this.lblCodArt = new System.Windows.Forms.Label();
            this.lblDescArt = new System.Windows.Forms.Label();
            this.lblMarcaArt = new System.Windows.Forms.Label();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.txbNombreArt = new System.Windows.Forms.TextBox();
            this.txbDescArt = new System.Windows.Forms.TextBox();
            this.lblPrecioArt = new System.Windows.Forms.Label();
            this.cboMarcaArt = new System.Windows.Forms.ComboBox();
            this.lblCatArt = new System.Windows.Forms.Label();
            this.cboCatArt = new System.Windows.Forms.ComboBox();
            this.btnAgregarArt = new System.Windows.Forms.Button();
            this.btnCancelarAgregar = new System.Windows.Forms.Button();
            this.lblLinkImagen = new System.Windows.Forms.Label();
            this.txbUrlImagen = new System.Windows.Forms.TextBox();
            this.txbCodigoArt = new System.Windows.Forms.TextBox();
            this.pbxAgregarArt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarArt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregar.Location = new System.Drawing.Point(80, 26);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(292, 40);
            this.lblAgregar.TabIndex = 0;
            this.lblAgregar.Text = "Agregar articulo";
            // 
            // lblNombreArt
            // 
            this.lblNombreArt.AutoSize = true;
            this.lblNombreArt.Location = new System.Drawing.Point(139, 161);
            this.lblNombreArt.Name = "lblNombreArt";
            this.lblNombreArt.Size = new System.Drawing.Size(47, 13);
            this.lblNombreArt.TabIndex = 1;
            this.lblNombreArt.Text = "Nombre:";
            // 
            // lblCodArt
            // 
            this.lblCodArt.AutoSize = true;
            this.lblCodArt.Location = new System.Drawing.Point(143, 131);
            this.lblCodArt.Name = "lblCodArt";
            this.lblCodArt.Size = new System.Drawing.Size(43, 13);
            this.lblCodArt.TabIndex = 1;
            this.lblCodArt.Text = "Codigo:";
            // 
            // lblDescArt
            // 
            this.lblDescArt.AutoSize = true;
            this.lblDescArt.Location = new System.Drawing.Point(121, 193);
            this.lblDescArt.Name = "lblDescArt";
            this.lblDescArt.Size = new System.Drawing.Size(66, 13);
            this.lblDescArt.TabIndex = 1;
            this.lblDescArt.Text = "Descripcion:";
            // 
            // lblMarcaArt
            // 
            this.lblMarcaArt.AutoSize = true;
            this.lblMarcaArt.Location = new System.Drawing.Point(146, 223);
            this.lblMarcaArt.Name = "lblMarcaArt";
            this.lblMarcaArt.Size = new System.Drawing.Size(40, 13);
            this.lblMarcaArt.TabIndex = 1;
            this.lblMarcaArt.Text = "Marca:";
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(192, 276);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(100, 20);
            this.txbPrecio.TabIndex = 5;
            this.txbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgregarArt_KeyPress);
            // 
            // txbNombreArt
            // 
            this.txbNombreArt.Location = new System.Drawing.Point(192, 158);
            this.txbNombreArt.Name = "txbNombreArt";
            this.txbNombreArt.Size = new System.Drawing.Size(100, 20);
            this.txbNombreArt.TabIndex = 1;
            this.txbNombreArt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgregarArt_KeyPress);
            // 
            // txbDescArt
            // 
            this.txbDescArt.Location = new System.Drawing.Point(192, 189);
            this.txbDescArt.Name = "txbDescArt";
            this.txbDescArt.Size = new System.Drawing.Size(100, 20);
            this.txbDescArt.TabIndex = 2;
            this.txbDescArt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgregarArt_KeyPress);
            // 
            // lblPrecioArt
            // 
            this.lblPrecioArt.AutoSize = true;
            this.lblPrecioArt.Location = new System.Drawing.Point(146, 281);
            this.lblPrecioArt.Name = "lblPrecioArt";
            this.lblPrecioArt.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioArt.TabIndex = 1;
            this.lblPrecioArt.Text = "Precio:";
            // 
            // cboMarcaArt
            // 
            this.cboMarcaArt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcaArt.FormattingEnabled = true;
            this.cboMarcaArt.Location = new System.Drawing.Point(192, 217);
            this.cboMarcaArt.Name = "cboMarcaArt";
            this.cboMarcaArt.Size = new System.Drawing.Size(100, 21);
            this.cboMarcaArt.TabIndex = 3;
            this.cboMarcaArt.SelectedIndexChanged += new System.EventHandler(this.cboMarcaArt_SelectedIndexChanged);
            this.cboMarcaArt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgregarArt_KeyPress);
            // 
            // lblCatArt
            // 
            this.lblCatArt.AutoSize = true;
            this.lblCatArt.Location = new System.Drawing.Point(131, 252);
            this.lblCatArt.Name = "lblCatArt";
            this.lblCatArt.Size = new System.Drawing.Size(55, 13);
            this.lblCatArt.TabIndex = 1;
            this.lblCatArt.Text = "Categoria:";
            // 
            // cboCatArt
            // 
            this.cboCatArt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCatArt.FormattingEnabled = true;
            this.cboCatArt.Location = new System.Drawing.Point(192, 246);
            this.cboCatArt.Name = "cboCatArt";
            this.cboCatArt.Size = new System.Drawing.Size(100, 21);
            this.cboCatArt.TabIndex = 4;
            this.cboCatArt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgregarArt_KeyPress);
            // 
            // btnAgregarArt
            // 
            this.btnAgregarArt.Location = new System.Drawing.Point(149, 354);
            this.btnAgregarArt.Name = "btnAgregarArt";
            this.btnAgregarArt.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarArt.TabIndex = 7;
            this.btnAgregarArt.Text = "Aceptar";
            this.btnAgregarArt.UseVisualStyleBackColor = true;
            this.btnAgregarArt.Click += new System.EventHandler(this.btnAgregarArt_Click);
            this.btnAgregarArt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgregarArt_KeyPress);
            // 
            // btnCancelarAgregar
            // 
            this.btnCancelarAgregar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarAgregar.Location = new System.Drawing.Point(240, 354);
            this.btnCancelarAgregar.Name = "btnCancelarAgregar";
            this.btnCancelarAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAgregar.TabIndex = 8;
            this.btnCancelarAgregar.Text = "Cancelar";
            this.btnCancelarAgregar.UseVisualStyleBackColor = true;
            this.btnCancelarAgregar.Click += new System.EventHandler(this.btnCancelarAgregar_Click);
            // 
            // lblLinkImagen
            // 
            this.lblLinkImagen.AutoSize = true;
            this.lblLinkImagen.Location = new System.Drawing.Point(118, 311);
            this.lblLinkImagen.Name = "lblLinkImagen";
            this.lblLinkImagen.Size = new System.Drawing.Size(69, 13);
            this.lblLinkImagen.TabIndex = 1;
            this.lblLinkImagen.Text = "URL imagen:";
            // 
            // txbUrlImagen
            // 
            this.txbUrlImagen.Location = new System.Drawing.Point(192, 308);
            this.txbUrlImagen.Name = "txbUrlImagen";
            this.txbUrlImagen.Size = new System.Drawing.Size(100, 20);
            this.txbUrlImagen.TabIndex = 6;
            this.txbUrlImagen.TextChanged += new System.EventHandler(this.txbUrlImagen_TextChanged);
            this.txbUrlImagen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgregarArt_KeyPress);
            // 
            // txbCodigoArt
            // 
            this.txbCodigoArt.Location = new System.Drawing.Point(192, 128);
            this.txbCodigoArt.Name = "txbCodigoArt";
            this.txbCodigoArt.Size = new System.Drawing.Size(100, 20);
            this.txbCodigoArt.TabIndex = 0;
            this.txbCodigoArt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgregarArt_KeyPress);
            // 
            // pbxAgregarArt
            // 
            this.pbxAgregarArt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxAgregarArt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxAgregarArt.Location = new System.Drawing.Point(410, 64);
            this.pbxAgregarArt.Name = "pbxAgregarArt";
            this.pbxAgregarArt.Size = new System.Drawing.Size(205, 264);
            this.pbxAgregarArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAgregarArt.TabIndex = 9;
            this.pbxAgregarArt.TabStop = false;
            // 
            // frmAgregarArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelarAgregar;
            this.ClientSize = new System.Drawing.Size(648, 401);
            this.Controls.Add(this.pbxAgregarArt);
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
            this.Controls.Add(this.lblAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAgregarArt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "v";
            this.Load += new System.EventHandler(this.frmAgregarArt_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgregarArt_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.Label lblNombreArt;
        private System.Windows.Forms.Label lblCodArt;
        private System.Windows.Forms.Label lblDescArt;
        private System.Windows.Forms.Label lblMarcaArt;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.TextBox txbNombreArt;
        private System.Windows.Forms.TextBox txbDescArt;
        private System.Windows.Forms.Label lblPrecioArt;
        private System.Windows.Forms.ComboBox cboMarcaArt;
        private System.Windows.Forms.Label lblCatArt;
        private System.Windows.Forms.ComboBox cboCatArt;
        private System.Windows.Forms.Button btnCancelarAgregar;
        private System.Windows.Forms.Label lblLinkImagen;
        private System.Windows.Forms.TextBox txbUrlImagen;
        private System.Windows.Forms.TextBox txbCodigoArt;
        public System.Windows.Forms.Button btnAgregarArt;
        private System.Windows.Forms.PictureBox pbxAgregarArt;
    }
}