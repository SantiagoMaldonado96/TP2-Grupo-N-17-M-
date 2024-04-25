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
                cargarImagen(lista[0].Imagen.UrlImagen);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArt ventana = new frmAgregarArt(this);
            ventana.ShowDialog();
            cargarDvgArticulos();
        }

        private void btnModificarArt_Click(object sender, EventArgs e)
        {
            frmModificarArticulo ventanaModificar = new frmModificarArticulo();

            //Definir como padre de ventanaModificar
            AddOwnedForm(ventanaModificar);

            //Pasar los valores del articulo seleccionado en lwArticulos, a los campos a Modificar
            /*ventanaModificar.txbCodigoArt.Text = this.dvgArticulos.
            ventanaModificar.txbNombreArt.Text = this.lwArticulos.SelectedItems[0].SubItems[1].Text;
            ventanaModificar.txbDescArt.Text = this.lwArticulos.SelectedItems[0].SubItems[2].Text;
            ventanaModificar.cboMarcaArt.Text = this.lwArticulos.SelectedItems[0].SubItems[3].Text;
            ventanaModificar.cboCatArt.Text = this.lwArticulos.SelectedItems[0].SubItems[4].Text;
            ventanaModificar.txbPrecio.Text = this.lwArticulos.SelectedItems[0].SubItems[5].Text;
            ventanaModificar.txbUrlImagen.Text = this.lwArticulos.SelectedItems[0].SubItems[6].Text;*/

            ventanaModificar.ShowDialog();
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

                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminarArticulo(seleccionado.Id);
                    cargarDvgArticulos();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

       
        private void frmVentanaListarArticulos_Load(object sender, EventArgs e)
        {
            cargarDvgArticulos();
            
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
            Articulo seleccion = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccion.Imagen.UrlImagen);
        }
    }
}
