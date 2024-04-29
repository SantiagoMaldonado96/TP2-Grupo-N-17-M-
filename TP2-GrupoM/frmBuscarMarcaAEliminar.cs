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
    public partial class frmBuscarMarcaAEliminar : Form
    {
        public frmBuscarMarcaAEliminar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            ArticuloNegocio negocioArt = new ArticuloNegocio();
            string busqueda = txbBuscarMarca.Text;
            Marca seleccionado = negocio.buscarMarcaPorNombre(busqueda);

            try
            {
                if (seleccionado != null)
                {
                bool existente = negocioArt.buscarIdMarca(seleccionado.IdMarca);
                    DialogResult respuesta = MessageBox.Show("¿Esta seguro que quiere eliminar la marca?", "Eliminar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (existente == false)
                        {
                            negocio.eliminarMarca(seleccionado.IdMarca);
                            MessageBox.Show("Marca eliminada con exito");
                        }
                        else
                        {
                            MessageBox.Show("Esta Marca no puede ser eliminaada porque tiene Articulos vinculados");
                        }                        
                    }
                }
                else
                {
                    MessageBox.Show("Marca no encontrada");
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
