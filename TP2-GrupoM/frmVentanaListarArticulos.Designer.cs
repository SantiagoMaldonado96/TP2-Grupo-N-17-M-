
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
            this.sstCantidadArticulos = new System.Windows.Forms.StatusStrip();
            this.stlblCantidadArticulos = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlblNumeroArticulos = new System.Windows.Forms.ToolStripStatusLabel();
            this.sstCantidadArticulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloListadoArticulos
            // 
            this.lblTituloListadoArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTituloListadoArticulos.AutoSize = true;
            this.lblTituloListadoArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloListadoArticulos.Location = new System.Drawing.Point(105, 36);
            this.lblTituloListadoArticulos.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTituloListadoArticulos.Name = "lblTituloListadoArticulos";
            this.lblTituloListadoArticulos.Size = new System.Drawing.Size(315, 37);
            this.lblTituloListadoArticulos.TabIndex = 0;
            this.lblTituloListadoArticulos.Text = "Articulos Disponibles";
            this.lblTituloListadoArticulos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lwArticulos
            // 
            this.lwArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lwArticulos.BackColor = System.Drawing.SystemColors.Info;
            this.lwArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lwArticulos.HideSelection = false;
            this.lwArticulos.Location = new System.Drawing.Point(112, 96);
            this.lwArticulos.Name = "lwArticulos";
            this.lwArticulos.Size = new System.Drawing.Size(292, 442);
            this.lwArticulos.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lwArticulos.TabIndex = 1;
            this.lwArticulos.UseCompatibleStateImageBehavior = false;
            // 
            // sstCantidadArticulos
            // 
            this.sstCantidadArticulos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlblCantidadArticulos,
            this.stlblNumeroArticulos});
            this.sstCantidadArticulos.Location = new System.Drawing.Point(0, 583);
            this.sstCantidadArticulos.Name = "sstCantidadArticulos";
            this.sstCantidadArticulos.Size = new System.Drawing.Size(492, 22);
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
            // frmVentanaListarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 605);
            this.Controls.Add(this.sstCantidadArticulos);
            this.Controls.Add(this.lwArticulos);
            this.Controls.Add(this.lblTituloListadoArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVentanaListarArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listado de Articulos";
            this.sstCantidadArticulos.ResumeLayout(false);
            this.sstCantidadArticulos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloListadoArticulos;
        private System.Windows.Forms.ListView lwArticulos;
        private System.Windows.Forms.StatusStrip sstCantidadArticulos;
        private System.Windows.Forms.ToolStripStatusLabel stlblCantidadArticulos;
        private System.Windows.Forms.ToolStripStatusLabel stlblNumeroArticulos;
    }
}