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
        /*//Lista de articulos
        List<Articulo> listaArticulos = new List<Articulo>();*/

        frmVentanaListarArticulos frmArticulos = new frmVentanaListarArticulos();

        public frmAgregarArt(frmVentanaListarArticulos frmArticulos)
        {
            InitializeComponent();
            //referencia del formulario listarArticulos
            this.frmArticulos = frmArticulos;
        }

        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            ///Cargar datos en lwArticulos

            //creo un objeto ListViewItem en donde voy a guardar los subitens
            ListViewItem item = new ListViewItem();

            item.Text= txbCodigoArt.Text;

            //cargo los subitems dentro del objeto "item"
            item.SubItems.Add(txbNombreArt.Text);
            item.SubItems.Add(txbDescArt.Text);
            item.SubItems.Add(cboMarcaArt.Text);
            item.SubItems.Add(cboCatArt.Text);
            item.SubItems.Add(txbPrecio.Text);
            item.SubItems.Add(txbUrlImagen.Text);

            //agrego el objeto "item" dentro del listView
            frmArticulos.lwArticulos.Items.Add(item);

            //limpiar campos del textBox una vez cargado los datos
            txbNombreArt.Text = "";
            txbCodigoArt.Text = "";
            txbDescArt.Text = "";
            cboMarcaArt.Text = "";
            cboCatArt.Text = "";
            txbPrecio.Text = "";
            txbUrlImagen.Text = "";

            this.Close();

        }

        private void btnCancelarAgregar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
