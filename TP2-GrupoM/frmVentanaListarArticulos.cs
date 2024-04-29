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
    public partial class frmVentanaListarArticulos : Form
    {
        private List<Articulo> lista;

        public frmVentanaListarArticulos()
        {
            InitializeComponent();

        }
        private void cargarDvgArticulos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                lista = negocio.listar();
                dvgArticulos.DataSource = lista;
                dvgArticulos.Columns["Imagen"].Visible = false;
                dvgArticulos.Columns["Id"].Visible = false;
                dvgArticulos.Columns["Descripcion"].Visible=false;
                cargarImagen(lista[0].Imagen.UrlImagen);

                stlblNumeroArticulos.Text = negocio.listar().Count().ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArt ventana = new frmAgregarArt();
            ventana.ShowDialog();
            cargarDvgArticulos();
        }

        private void btnModificarArt_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo seleccionado = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;

                frmAgregarArt ventanaModificar = new frmAgregarArt(seleccionado);
                ventanaModificar.ShowDialog();
                dvgArticulos.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                MessageBox.Show("Articulo seleccionado no valido");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarArt_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Esta seguro que quiere eliminar el Articulo seleccionado?", "Eliminar Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminarArticulo(seleccionado.Id);
                    cargarDvgArticulos();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void frmVentanaListarArticulos_Load(object sender, EventArgs e)
        {
            cargarDvgArticulos();
            //desplegables Filtro Avanzado
            cboCampo.Items.Add("Codigo");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("A.Descripcion");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Precio");
        }

        public void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://img.freepik.com/vector-gratis/ilustracion-icono-galeria_53876-27002.jpg?w=740&t=st=1713761428~exp=1713762028~hmac=6cc05cab5ff21644c477ae1afb475c8e48695528279b2f6ce99f879ae6a97242");
            }

        }

        private void dvgArticulos_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dvgArticulos.CurrentRow != null)
            {
                Articulo seleccion = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccion.Imagen.UrlImagen);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if(cboCriterio.SelectedItem != null)
                {
                    string campo = cboCampo.SelectedItem.ToString();
                    string criterio = cboCriterio.SelectedItem.ToString();
                    string filtro = txbFiltro.Text;
                    dvgArticulos.DataSource = negocio.filtroAvanzado(campo, criterio, filtro);
                }
            }
            catch (Exception)
            {

                cargarDvgArticulos();
            }
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            lista = negocio.buscarArticulo(txtBuscar.Text);

            try
            {
                if (txtBuscar.Text.Length <= 3)
                {
                    cargarDvgArticulos();
                }
                else
                {
                    dvgArticulos.DataSource = lista;
                    dvgArticulos.Columns["Imagen"].Visible = false;
                    dvgArticulos.Columns["Id"].Visible = false;
                    cargarImagen(lista[0].Imagen.UrlImagen);
                }
            }
            catch (Exception)
            {

                cargarDvgArticulos();
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opt = cboCampo.SelectedItem.ToString();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                switch (opt)
                {
                    case "Precio":
                        cboCriterio.DataSource = null;
                        cboCriterio.Items.Clear();
                        cboCriterio.Items.Add("Mayor a");
                        cboCriterio.Items.Add("Igual a");
                        cboCriterio.Items.Add("Menor a");
                        break;
                    case "Marca":
                        cboCriterio.DataSource = marcaNegocio.listar();
                        break;
                    case "Categoria":
                        cboCriterio.DataSource = categoriaNegocio.listar();
                        break;
                    default:
                        cboCriterio.DataSource = null; //Limpia si Criterio era categoria o marca
                        cboCriterio.Items.Clear();
                        cboCriterio.Items.Add("Comienza con");
                        cboCriterio.Items.Add("Contiene");
                        cboCriterio.Items.Add("Termina con");
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void cboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campo= cboCampo.SelectedItem.ToString();
            //Autocompleatado de tbxFiltro con Marca o Categoria
            if (campo== "Marca" || campo == "Categoria")
            {
                txbFiltro.Text = cboCriterio.SelectedItem.ToString();
                txbFiltro.ReadOnly = true;
            }
            else
            {
                txbFiltro.Text = "";
                txbFiltro.ReadOnly = false;
            }
            

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarDvgArticulos();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccion = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;
            frmDetalle ventana = new frmDetalle(seleccion);
            ventana.ShowDialog();
        }

    }
}
