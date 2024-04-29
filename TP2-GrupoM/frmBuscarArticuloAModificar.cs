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
    public partial class frmBuscarArticuloAModificar : Form
    {
        public frmBuscarArticuloAModificar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                string busqueda= txbBuscarArticulo.Text;
                articulo = negocio.buscarArticuloPorCodigo(busqueda);

                if(articulo != null)
                {
                    frmAgregarArt ventana = new frmAgregarArt(articulo);
                    ventana.ShowDialog();
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
