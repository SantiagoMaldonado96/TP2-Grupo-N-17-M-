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
    public partial class frmAgregarArt : Form
    {
        public frmAgregarArt()
        {
            InitializeComponent();
        }

        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            articulo.CodigoArticulo = int.Parse(txbCodigoArt.Text);
            articulo.Nombre = txbNombreArt.Text;
            articulo.Descripcion = txbDescArt.Text; 
            articulo.Marca = cboMarcaArt.Text;
            articulo.Categoria = cboCatArt.Text;
            articulo.Precio = (float)int.Parse(txbPrecio.Text);

            MessageBox.Show("nombre:" + articulo.Nombre + "\ncodigo:" + articulo.CodigoArticulo + "\ndescripcion:" + articulo.Descripcion + "\nprecio:" + articulo.Precio);
            
        }
    }
}
