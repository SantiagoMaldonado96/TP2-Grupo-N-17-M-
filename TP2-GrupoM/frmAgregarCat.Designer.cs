namespace TP2_GrupoM
{
    partial class frmAgregarCat
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
            this.btnCancelarCat = new System.Windows.Forms.Button();
            this.btnAgregarCat = new System.Windows.Forms.Button();
            this.txbCodigoCat = new System.Windows.Forms.TextBox();
            this.txbNombreCat = new System.Windows.Forms.TextBox();
            this.lblCodCat = new System.Windows.Forms.Label();
            this.lblNombreCat = new System.Windows.Forms.Label();
            this.lblAgregarMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarCat
            // 
            this.btnCancelarCat.Location = new System.Drawing.Point(219, 173);
            this.btnCancelarCat.Name = "btnCancelarCat";
            this.btnCancelarCat.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCat.TabIndex = 3;
            this.btnCancelarCat.Text = "Cancelar";
            this.btnCancelarCat.UseVisualStyleBackColor = true;
            this.btnCancelarCat.Click += new System.EventHandler(this.btnCancelarCat_Click);
            // 
            // btnAgregarCat
            // 
            this.btnAgregarCat.Location = new System.Drawing.Point(128, 173);
            this.btnAgregarCat.Name = "btnAgregarCat";
            this.btnAgregarCat.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCat.TabIndex = 2;
            this.btnAgregarCat.Text = "Agregar";
            this.btnAgregarCat.UseVisualStyleBackColor = true;
            this.btnAgregarCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgregarCat_KeyPress);
            // 
            // txbCodigoCat
            // 
            this.txbCodigoCat.Location = new System.Drawing.Point(162, 94);
            this.txbCodigoCat.Name = "txbCodigoCat";
            this.txbCodigoCat.Size = new System.Drawing.Size(100, 20);
            this.txbCodigoCat.TabIndex = 0;
            this.txbCodigoCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgregarCat_KeyPress);
            // 
            // txbNombreCat
            // 
            this.txbNombreCat.Location = new System.Drawing.Point(162, 124);
            this.txbNombreCat.Name = "txbNombreCat";
            this.txbNombreCat.Size = new System.Drawing.Size(100, 20);
            this.txbNombreCat.TabIndex = 1;
            this.txbNombreCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgregarCat_KeyPress);
            // 
            // lblCodCat
            // 
            this.lblCodCat.AutoSize = true;
            this.lblCodCat.Location = new System.Drawing.Point(112, 97);
            this.lblCodCat.Name = "lblCodCat";
            this.lblCodCat.Size = new System.Drawing.Size(43, 13);
            this.lblCodCat.TabIndex = 18;
            this.lblCodCat.Text = "Codigo:";
            // 
            // lblNombreCat
            // 
            this.lblNombreCat.AutoSize = true;
            this.lblNombreCat.Location = new System.Drawing.Point(108, 127);
            this.lblNombreCat.Name = "lblNombreCat";
            this.lblNombreCat.Size = new System.Drawing.Size(47, 13);
            this.lblNombreCat.TabIndex = 19;
            this.lblNombreCat.Text = "Nombre:";
            // 
            // lblAgregarMarca
            // 
            this.lblAgregarMarca.AutoSize = true;
            this.lblAgregarMarca.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarMarca.Location = new System.Drawing.Point(50, 33);
            this.lblAgregarMarca.Name = "lblAgregarMarca";
            this.lblAgregarMarca.Size = new System.Drawing.Size(327, 40);
            this.lblAgregarMarca.TabIndex = 16;
            this.lblAgregarMarca.Text = "Agregar Categoria";
            // 
            // frmAgregarCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 223);
            this.Controls.Add(this.btnCancelarCat);
            this.Controls.Add(this.btnAgregarCat);
            this.Controls.Add(this.txbCodigoCat);
            this.Controls.Add(this.txbNombreCat);
            this.Controls.Add(this.lblCodCat);
            this.Controls.Add(this.lblNombreCat);
            this.Controls.Add(this.lblAgregarMarca);
            this.Name = "frmAgregarCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAgregarCat";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgregarCat_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarCat;
        private System.Windows.Forms.Button btnAgregarCat;
        private System.Windows.Forms.TextBox txbCodigoCat;
        private System.Windows.Forms.TextBox txbNombreCat;
        private System.Windows.Forms.Label lblCodCat;
        private System.Windows.Forms.Label lblNombreCat;
        private System.Windows.Forms.Label lblAgregarMarca;
    }
}