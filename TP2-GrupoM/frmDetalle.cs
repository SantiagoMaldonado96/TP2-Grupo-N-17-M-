using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_GrupoM
{
    public partial class frmDetalle : Form
    {
        public frmDetalle(Articulo articulo)
        {
            InitializeComponent();
            tbxCodigo.Text = articulo.CodigoArticulo;
            tbxNombre.Text = articulo.Nombre;
            tbxMarca.Text = articulo.Marca.NombreMarca;
            tbxCat.Text = articulo.Cat.NombreCategoria;
            //lblDescripcion.MaximumSize = new System.Drawing.Size(100, 0);
            //lblDescripcion.AutoSize = true;
            tbxDesc.Text = articulo.Descripcion;
            tbxPrecio.Text = articulo.Precio.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
