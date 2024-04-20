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
        //Lista de articulos. Falta hacerla Global
        List<Articulo> listaArticulos = new List<Articulo>();

        public frmAgregarArt()
        {
            InitializeComponent();
        }

        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            articulo.Nombre = txbNombreArt.Text;
            articulo.CodigoArticulo = int.Parse(txbCodigoArt.Text);
            articulo.Descripcion = txbDescArt.Text;
            articulo.Marca = cboMarcaArt.Text;
            articulo.Categoria = cboCatArt.Text;
            articulo.Precio = (float)int.Parse(txbPrecio.Text);

            MessageBox.Show("nombre:" + articulo.Nombre + "\ncodigo:" + articulo.CodigoArticulo + "\ndescripcion:" + articulo.Descripcion + "\nprecio:" + articulo.Precio);


            /*// Agregar articulos cargados a la lista de articulos.
            foreach (Articulo articulo in listaArticulos)
            {
                articulo.Nombre = txbNombreArt.Text;
                articulo.CodigoArticulo = int.Parse(txbCodigoArt.Text);
                articulo.Descripcion = txbDescArt.Text;
                articulo.Marca = cboMarcaArt.Text;
                articulo.Categoria = cboCatArt.Text;
                articulo.Precio = (float)int.Parse(txbPrecio.Text);

                MessageBox.Show("nombre:" + articulo.Nombre + "\ncodigo:" + articulo.CodigoArticulo + "\ndescripcion:" + articulo.Descripcion + "\nprecio:" + articulo.Precio);
            }*/
            
            //Borrar campos del textBox una vez cargado los datos
            txbNombreArt.Text = "";
            txbCodigoArt.Text = "";
            txbDescArt.Text = "";
            cboMarcaArt.Text = "";
            cboCatArt.Text = "";
            txbPrecio.Text = "";
            txbUrlImagen.Text = "";

        }

        private void btnCancelarAgregar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
