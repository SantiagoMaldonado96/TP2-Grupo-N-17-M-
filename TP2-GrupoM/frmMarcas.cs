using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TP2_GrupoM
{
    public partial class frmMarcas : Form    
    {
        private List<Marca> lista;
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void cargarDgvmarcas()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                lista = negocio.listar();
                dgvMarcas.DataSource = lista;
                dgvMarcas.Columns["IdMarca"].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAgregarMarca ventana = new frmAgregarMarca();   
            ventana.ShowDialog();
            cargarDgvmarcas();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Esta seguro de querer eliminar la Marca seleccionada?", "Eliminar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    negocio.eliminarMarca(seleccionado.IdMarca);
                    cargarDgvmarcas();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            cargarDgvmarcas();
        }
    }
}
