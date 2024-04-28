namespace TP2_GrupoM
{
    partial class frmAgregarMarca
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
            this.lblAgregarMarca = new System.Windows.Forms.Label();
            this.txbNombreMarca = new System.Windows.Forms.TextBox();
            this.lblNombreMarca = new System.Windows.Forms.Label();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAgregarMarca
            // 
            this.lblAgregarMarca.AutoSize = true;
            this.lblAgregarMarca.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarMarca.Location = new System.Drawing.Point(60, 24);
            this.lblAgregarMarca.Name = "lblAgregarMarca";
            this.lblAgregarMarca.Size = new System.Drawing.Size(265, 40);
            this.lblAgregarMarca.TabIndex = 1;
            this.lblAgregarMarca.Text = "Agregar Marca";
            // 
            // txbNombreMarca
            // 
            this.txbNombreMarca.Location = new System.Drawing.Point(147, 92);
            this.txbNombreMarca.Name = "txbNombreMarca";
            this.txbNombreMarca.Size = new System.Drawing.Size(100, 20);
            this.txbNombreMarca.TabIndex = 1;
            this.txbNombreMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgregarMarca_KeyPress);
            // 
            // lblNombreMarca
            // 
            this.lblNombreMarca.AutoSize = true;
            this.lblNombreMarca.Location = new System.Drawing.Point(93, 95);
            this.lblNombreMarca.Name = "lblNombreMarca";
            this.lblNombreMarca.Size = new System.Drawing.Size(47, 13);
            this.lblNombreMarca.TabIndex = 12;
            this.lblNombreMarca.Text = "Nombre:";
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarMarca.Location = new System.Drawing.Point(204, 141);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMarca.TabIndex = 3;
            this.btnCancelarMarca.Text = "C&ancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = true;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(113, 141);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMarca.TabIndex = 2;
            this.btnAgregarMarca.Text = "A&gregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            this.btnAgregarMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgregarMarca_KeyPress);
            // 
            // frmAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelarMarca;
            this.ClientSize = new System.Drawing.Size(376, 200);
            this.Controls.Add(this.btnCancelarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.txbNombreMarca);
            this.Controls.Add(this.lblNombreMarca);
            this.Controls.Add(this.lblAgregarMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAgregarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Marca";
            this.Load += new System.EventHandler(this.frmAgregarMarca_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgregarMarca_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarMarca;
        private System.Windows.Forms.TextBox txbNombreMarca;
        private System.Windows.Forms.Label lblNombreMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
    }
}