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
    public partial class frmCatalogo : Form
    {
        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            frmVentanaListarArticulos ventana = new frmVentanaListarArticulos();
            ventana.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias ventana = new frmCategorias();
            ventana.ShowDialog();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas ventana = new frmMarcas();
            ventana.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarArt ventana = new frmAgregarArt();
            ventana.ShowDialog();
            
        }

        private void modificarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarArticuloAModificar ventana = new frmBuscarArticuloAModificar();
            ventana.ShowDialog();

            
        }

        private void eliminarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarArticuloAEliminar ventana = new frmBuscarArticuloAEliminar();
            ventana.ShowDialog();
     
        }

        private void eliminarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarMarcaAEliminar ventana = new frmBuscarMarcaAEliminar();
            ventana.ShowDialog();
        }

        private void modificarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarMarcaAModificar ventana = new frmBuscarMarcaAModificar();
            ventana.ShowDialog();
        }

        private void agregarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarMarca ventana = new frmAgregarMarca();
            ventana.ShowDialog();
        }

        private void agregarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCat ventana = new frmAgregarCat();
            ventana.ShowDialog();
        }

        private void modificarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarCategoriaAModificar ventana = new frmBuscarCategoriaAModificar();
            ventana.ShowDialog();
        }

        private void eliminarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarCategoriaAEliminar ventana = new frmBuscarCategoriaAEliminar();
            ventana.ShowDialog();
        }
    }
}
