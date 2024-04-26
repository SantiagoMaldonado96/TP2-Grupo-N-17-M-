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
            bool existente;
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado;
            ArticuloNegocio negocioArt = new ArticuloNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Esta seguro de querer eliminar la Marca seleccionada?", "Eliminar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                existente = negocioArt.buscarIdMarca(seleccionado.IdMarca);

                if (respuesta == DialogResult.Yes && existente == false)
                {
                    negocio.eliminarMarca(seleccionado.IdMarca);
                    cargarDgvmarcas();
                }
                else
                {
                    MessageBox.Show("Esta Marca no puede ser eliminaada porque tiene Articulos vinculados");
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

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                Marca seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

                frmAgregarMarca ventanaModificar = new frmAgregarMarca(seleccionado);
                ventanaModificar.ShowDialog();
                cargarDgvmarcas();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                MessageBox.Show("Marca seleccionada no valida");
            }
        }
    }
}
