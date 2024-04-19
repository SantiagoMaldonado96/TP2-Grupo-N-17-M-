namespace TP2_GrupoM
{
    partial class frmBuscarArt
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
            this.lblBuscarArt = new System.Windows.Forms.Label();
            this.lblBuscarCod = new System.Windows.Forms.Label();
            this.lblNombreBuscar = new System.Windows.Forms.Label();
            this.txbBuscarCod = new System.Windows.Forms.TextBox();
            this.txbBuscarNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelarBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBuscarArt
            // 
            this.lblBuscarArt.AutoSize = true;
            this.lblBuscarArt.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarArt.Location = new System.Drawing.Point(82, 29);
            this.lblBuscarArt.Name = "lblBuscarArt";
            this.lblBuscarArt.Size = new System.Drawing.Size(272, 40);
            this.lblBuscarArt.TabIndex = 0;
            this.lblBuscarArt.Text = "Buscar articulo";
            // 
            // lblBuscarCod
            // 
            this.lblBuscarCod.AutoSize = true;
            this.lblBuscarCod.Location = new System.Drawing.Point(130, 88);
            this.lblBuscarCod.Name = "lblBuscarCod";
            this.lblBuscarCod.Size = new System.Drawing.Size(81, 13);
            this.lblBuscarCod.TabIndex = 1;
            this.lblBuscarCod.Text = "Codigo Articulo:";
            // 
            // lblNombreBuscar
            // 
            this.lblNombreBuscar.AutoSize = true;
            this.lblNombreBuscar.Location = new System.Drawing.Point(127, 122);
            this.lblNombreBuscar.Name = "lblNombreBuscar";
            this.lblNombreBuscar.Size = new System.Drawing.Size(84, 13);
            this.lblNombreBuscar.TabIndex = 1;
            this.lblNombreBuscar.Text = "Nombre articulo:";
            // 
            // txbBuscarCod
            // 
            this.txbBuscarCod.Location = new System.Drawing.Point(217, 85);
            this.txbBuscarCod.Name = "txbBuscarCod";
            this.txbBuscarCod.Size = new System.Drawing.Size(100, 20);
            this.txbBuscarCod.TabIndex = 2;
            // 
            // txbBuscarNombre
            // 
            this.txbBuscarNombre.Location = new System.Drawing.Point(217, 119);
            this.txbBuscarNombre.Name = "txbBuscarNombre";
            this.txbBuscarNombre.Size = new System.Drawing.Size(100, 20);
            this.txbBuscarNombre.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(139, 167);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarBuscar
            // 
            this.btnCancelarBuscar.Location = new System.Drawing.Point(232, 167);
            this.btnCancelarBuscar.Name = "btnCancelarBuscar";
            this.btnCancelarBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarBuscar.TabIndex = 3;
            this.btnCancelarBuscar.Text = "Cancelar";
            this.btnCancelarBuscar.UseVisualStyleBackColor = true;
            // 
            // frmBuscarArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 224);
            this.Controls.Add(this.btnCancelarBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbBuscarNombre);
            this.Controls.Add(this.txbBuscarCod);
            this.Controls.Add(this.lblNombreBuscar);
            this.Controls.Add(this.lblBuscarCod);
            this.Controls.Add(this.lblBuscarArt);
            this.Name = "frmBuscarArt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBuscarArt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarArt;
        private System.Windows.Forms.Label lblBuscarCod;
        private System.Windows.Forms.Label lblNombreBuscar;
        private System.Windows.Forms.TextBox txbBuscarCod;
        private System.Windows.Forms.TextBox txbBuscarNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelarBuscar;
    }
}