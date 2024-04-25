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
            EliminarCategoria ventana = new EliminarCategoria();
            ventana.ShowDialog();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            cargarDgvCategorias();
        }
    }
}
