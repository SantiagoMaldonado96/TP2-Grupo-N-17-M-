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
    public partial class frmBuscarMarcaAModificar : Form
    {
        public frmBuscarMarcaAModificar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Marca seleccionado = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                string busqueda= txbBuscarMarca.Text;
                seleccionado = negocio.buscarMarcaPorNombre(busqueda);

                if(seleccionado != null)
                {
                    frmAgregarMarca ventana = new frmAgregarMarca(seleccionado);
                    ventana.ShowDialog();
                    this.Close();
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
