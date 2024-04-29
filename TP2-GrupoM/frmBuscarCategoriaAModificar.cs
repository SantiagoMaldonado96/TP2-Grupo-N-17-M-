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
    public partial class frmBuscarCategoriaAModificar : Form
    {
        public frmBuscarCategoriaAModificar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Categoria seleccionado = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                string busqueda= txbBuscarCategoria.Text;
                seleccionado = negocio.buscarCategoriaPorNombre(busqueda);

                if(seleccionado != null)
                {
                    frmAgregarCat ventana = new frmAgregarCat(seleccionado);
                    ventana.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Categoria no encontrada");
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
