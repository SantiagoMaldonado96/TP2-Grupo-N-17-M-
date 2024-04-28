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
            this.txbNombreCat = new System.Windows.Forms.TextBox();
            this.lblNombreCat = new System.Windows.Forms.Label();
            this.lblAgregarMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarCat
            // 
            this.btnCancelarCat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarCat.Location = new System.Drawing.Point(219, 173);
            this.btnCancelarCat.Name = "btnCancelarCat";
            this.btnCancelarCat.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCat.TabIndex = 3;
            this.btnCancelarCat.Text = "C&ancelar";
            this.btnCancelarCat.UseVisualStyleBackColor = true;
            this.btnCancelarCat.Click += new System.EventHandler(this.btnCancelarCat_Click);
            // 
            // btnAgregarCat
            // 
            this.btnAgregarCat.Location = new System.Drawing.Point(128, 173);
            this.btnAgregarCat.Name = "btnAgregarCat";
            this.btnAgregarCat.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCat.TabIndex = 2;
            this.btnAgregarCat.Text = "A&gregar";
            this.btnAgregarCat.UseVisualStyleBackColor = true;
            this.btnAgregarCat.Click += new System.EventHandler(this.btnAgregarCat_Click);
            this.btnAgregarCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgregarCat_KeyPress);
            // 
            // txbNombreCat
            // 
            this.txbNombreCat.Location = new System.Drawing.Point(168, 106);
            this.txbNombreCat.Name = "txbNombreCat";
            this.txbNombreCat.Size = new System.Drawing.Size(100, 20);
            this.txbNombreCat.TabIndex = 1;
            this.txbNombreCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgregarCat_KeyPress);
            // 
            // lblNombreCat
            // 
            this.lblNombreCat.AutoSize = true;
            this.lblNombreCat.Location = new System.Drawing.Point(114, 109);
            this.lblNombreCat.Name = "lblNombreCat";
            this.lblNombreCat.Size = new System.Drawing.Size(47, 13);
            this.lblNombreCat.TabIndex = 0;
            this.lblNombreCat.Text = "Nombre:";
            // 
            // lblAgregarMarca
            // 
            this.lblAgregarMarca.AutoSize = true;
            this.lblAgregarMarca.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarMarca.Location = new System.Drawing.Point(50, 33);
            this.lblAgregarMarca.Name = "lblAgregarMarca";
            this.lblAgregarMarca.Size = new System.Drawing.Size(327, 40);
            this.lblAgregarMarca.TabIndex = 0;
            this.lblAgregarMarca.Text = "Agregar Categoria";
            // 
            // frmAgregarCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelarCat;
            this.ClientSize = new System.Drawing.Size(408, 223);
            this.Controls.Add(this.btnCancelarCat);
            this.Controls.Add(this.btnAgregarCat);
            this.Controls.Add(this.txbNombreCat);
            this.Controls.Add(this.lblNombreCat);
            this.Controls.Add(this.lblAgregarMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAgregarCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Categoria";
            this.Load += new System.EventHandler(this.frmAgregarCat_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgregarCat_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarCat;
        private System.Windows.Forms.Button btnAgregarCat;
        private System.Windows.Forms.Label lblNombreCat;
        private System.Windows.Forms.Label lblAgregarMarca;
        public System.Windows.Forms.TextBox txbNombreCat;
    }
}