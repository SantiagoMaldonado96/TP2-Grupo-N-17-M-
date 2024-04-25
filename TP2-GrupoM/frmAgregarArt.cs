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
    public partial class frmAgregarArt : Form
    {
        /*//Lista de articulos
        List<Articulo> listaArticulos = new List<Articulo>();*/

        frmVentanaListarArticulos frmArticulos = new frmVentanaListarArticulos();

        public frmAgregarArt(frmVentanaListarArticulos frmArticulos)
        {
            InitializeComponent();
            //referencia del formulario listarArticulos
            this.frmArticulos = frmArticulos;
        }

        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            Imagen imagen = new Imagen();
            ImagenNegocio imgNegocio = new ImagenNegocio();

            try
            {
                articulo.CodigoArticulo = txbCodigoArt.Text;
                articulo.Nombre = txbNombreArt.Text;
                articulo.Descripcion = txbDescArt.Text;
                articulo.Marca = (Marca)cboMarcaArt.SelectedItem;
                articulo.Cat = (Categoria)cboCatArt.SelectedItem;
                articulo.Precio = decimal.Parse(txbPrecio.Text);

                negocio.agregar(articulo);
                //leer solo el registro que se subio y traer Id 
                int idbuscar = negocio.buscarId(articulo);
                //cargar ahora a tabla imegenes con id y url
                imagen.IdArtciulo = idbuscar;
                imagen.UrlImagen = txbUrlImagen.Text;

                imgNegocio.agregar(imagen);
                MessageBox.Show(idbuscar.ToString());



            }
            catch (Exception ex)
            {

                throw ex;
            }

            this.Close();

        }

        private void btnCancelarAgregar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmAgregarArt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Asigna al Enter para poder cambiar de foco (como el Tab)
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Previene el sonido de 'beep'
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void frmAgregarArt_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcanegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboMarcaArt.DataSource = marcanegocio.listar();
                cboCatArt.DataSource = categoriaNegocio.listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void cargarImagen(string imagen)
        {
            try
            {
                pbxAgregarArt.Load(imagen);
            }
            catch (Exception)
            {
                pbxAgregarArt.Load("https://img.freepik.com/vector-gratis/ilustracion-icono-galeria_53876-27002.jpg?w=740&t=st=1713761428~exp=1713762028~hmac=6cc05cab5ff21644c477ae1afb475c8e48695528279b2f6ce99f879ae6a97242");
            }

        }

        private void txbUrlImagen_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(txbUrlImagen.Text);
        }
    }
}
