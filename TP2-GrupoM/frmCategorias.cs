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
    public partial class frmCategorias : Form
    {
        private List<Categoria> lista;
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void cargarDgvCategorias()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                lista = negocio.listar();
                dgvCategorias.DataSource = lista;
                dgvCategorias.Columns["IdCategoria"].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            frmAgregarCat ventana = new frmAgregarCat();
            ventana.ShowDialog();
            cargarDgvCategorias();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {
            bool existente;
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionado;
            ArticuloNegocio negocioArt = new ArticuloNegocio();
            
            try
            {                
                DialogResult respuesta = MessageBox.Show("¿Esta seguro de querer eliminar la Categoria seleccionada?", "Eliminar Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                existente = negocioArt.buscarIdCategoria(seleccionado.IdCategoria);

                if (respuesta == DialogResult.Yes && existente == false)
                {
                    negocio.eliminarCategoria(seleccionado.IdCategoria);
                    cargarDgvCategorias();
                }
                else
                {
                    MessageBox.Show("Esta Categoria no puede ser eliminada porque tiene Articulos vinculados");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            cargarDgvCategorias();
        }
    }
}
