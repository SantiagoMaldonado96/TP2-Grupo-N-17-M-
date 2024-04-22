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
    public partial class frmVentanaListarArticulos : Form
    {

        public frmVentanaListarArticulos()
        {
            InitializeComponent();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArt ventana = new frmAgregarArt(this);
            ventana.ShowDialog();
        }

        private void btnModificarArt_Click(object sender, EventArgs e)
        {
            frmModificarArticulo ventanaModificar = new frmModificarArticulo();

            //Definir como padre de ventanaModificar
            AddOwnedForm(ventanaModificar);

            //Pasar los valores del articulo seleccionado en lwArticulos, a los campos a Modificar
            ventanaModificar.txbCodigoArt.Text = this.lwArticulos.SelectedItems[0].Text;
            ventanaModificar.txbNombreArt.Text = this.lwArticulos.SelectedItems[0].SubItems[1].Text;
            ventanaModificar.txbDescArt.Text = this.lwArticulos.SelectedItems[0].SubItems[2].Text;
            ventanaModificar.cboMarcaArt.Text = this.lwArticulos.SelectedItems[0].SubItems[3].Text;
            ventanaModificar.cboCatArt.Text = this.lwArticulos.SelectedItems[0].SubItems[4].Text;
            ventanaModificar.txbPrecio.Text = this.lwArticulos.SelectedItems[0].SubItems[5].Text;
            ventanaModificar.txbUrlImagen.Text = this.lwArticulos.SelectedItems[0].SubItems[6].Text;

            ventanaModificar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarArt_Click(object sender, EventArgs e)
        {
            EliminarArticulo ventana = new EliminarArticulo();
            ventana.ShowDialog();
        }

        private void lwArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void frmVentanaListarArticulos_Load(object sender, EventArgs e)
        {
           // ArticuloNegocio negocio = new ArticuloNegocio();
           // lwArticulos
        }
    }
}
