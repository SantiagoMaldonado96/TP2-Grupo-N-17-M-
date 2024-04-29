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
    public partial class frmBuscarCategoriaAEliminar : Form
    {
        public frmBuscarCategoriaAEliminar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            ArticuloNegocio negocioArt = new ArticuloNegocio();
            string busqueda = txbBuscarCategoria.Text;
            Categoria seleccionado = negocio.buscarCategoriaPorNombre(busqueda);

            try
            {
                if (seleccionado != null)
                {
                    bool existente = negocioArt.buscarIdCategoria(seleccionado.IdCategoria);
                    DialogResult respuesta = MessageBox.Show("¿Esta seguro que quiere eliminar esta categoria?", "Eliminar Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (existente == false)
                        {
                            negocio.eliminarCategoria(seleccionado.IdCategoria);
                            MessageBox.Show("Categoria eliminada con exito");
                        }
                        else
                        {
                            MessageBox.Show("Esta Categoria no puede ser eliminaada porque tiene Articulos vinculados");
                        }                        
                    }
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
