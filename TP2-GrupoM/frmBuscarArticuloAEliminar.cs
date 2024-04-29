using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace TP2_GrupoM
{
    public partial class frmBuscarArticuloAEliminar : Form
    {
        public frmBuscarArticuloAEliminar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            string busqueda = txbBuscarArticulo.Text;
            Articulo seleccionado = negocio.buscarArticuloPorCodigo(busqueda);

            try
            {
                if (seleccionado != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Esta seguro que quiere eliminar el Articulo?", "Eliminar Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        negocio.eliminarArticulo(seleccionado.Id);
                        MessageBox.Show("Articulo eliminado con exito");
                    }
                }
                else
                {
                    MessageBox.Show("Articulo no encontrado");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
