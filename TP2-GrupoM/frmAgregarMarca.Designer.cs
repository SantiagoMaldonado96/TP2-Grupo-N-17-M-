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
            this.txbCodigoMarca = new System.Windows.Forms.TextBox();
            this.txbNombreMarca = new System.Windows.Forms.TextBox();
            this.lblCodMarca = new System.Windows.Forms.Label();
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
            // txbCodigoMarca
            // 
            this.txbCodigoMarca.Location = new System.Drawing.Point(147, 89);
            this.txbCodigoMarca.Name = "txbCodigoMarca";
            this.txbCodigoMarca.Size = new System.Drawing.Size(100, 20);
            this.txbCodigoMarca.TabIndex = 13;
            // 
            // txbNombreMarca
            // 
            this.txbNombreMarca.Location = new System.Drawing.Point(147, 119);
            this.txbNombreMarca.Name = "txbNombreMarca";
            this.txbNombreMarca.Size = new System.Drawing.Size(100, 20);
            this.txbNombreMarca.TabIndex = 10;
            // 
            // lblCodMarca
            // 
            this.lblCodMarca.AutoSize = true;
            this.lblCodMarca.Location = new System.Drawing.Point(97, 92);
            this.lblCodMarca.Name = "lblCodMarca";
            this.lblCodMarca.Size = new System.Drawing.Size(43, 13);
            this.lblCodMarca.TabIndex = 11;
            this.lblCodMarca.Text = "Codigo:";
            // 
            // lblNombreMarca
            // 
            this.lblNombreMarca.AutoSize = true;
            this.lblNombreMarca.Location = new System.Drawing.Point(93, 122);
            this.lblNombreMarca.Name = "lblNombreMarca";
            this.lblNombreMarca.Size = new System.Drawing.Size(47, 13);
            this.lblNombreMarca.TabIndex = 12;
            this.lblNombreMarca.Text = "Nombre:";
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.Location = new System.Drawing.Point(204, 168);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMarca.TabIndex = 15;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = true;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(113, 168);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMarca.TabIndex = 14;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            // 
            // frmAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 223);
            this.Controls.Add(this.btnCancelarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.txbCodigoMarca);
            this.Controls.Add(this.txbNombreMarca);
            this.Controls.Add(this.lblCodMarca);
            this.Controls.Add(this.lblNombreMarca);
            this.Controls.Add(this.lblAgregarMarca);
            this.Name = "frmAgregarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAgregarMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarMarca;
        private System.Windows.Forms.TextBox txbCodigoMarca;
        private System.Windows.Forms.TextBox txbNombreMarca;
        private System.Windows.Forms.Label lblCodMarca;
        private System.Windows.Forms.Label lblNombreMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
    }
}