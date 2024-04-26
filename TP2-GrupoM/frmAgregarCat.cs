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
    public partial class frmAgregarCat : Form
    {
        private Categoria categoria = null;
        public frmAgregarCat()
        {
            InitializeComponent();
        }
        public frmAgregarCat(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoria";
        }

        private void btnCancelarCat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgregarCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Asigna al Enter para poder cambiar de foco (como el Tab)
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Previene el sonido de 'beep'
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (categoria == null) // Si es null se crea una categoria nueva
                    categoria = new Categoria();

                categoria.NombreCategoria = txbNombreCat.Text;

                if(categoria.IdCategoria != 0)
                {
                    //MODIFICAR CATEGORIA
                    negocio.ModificarCategoria(categoria);
                    MessageBox.Show("Modificacion Exitosa");
                }
                else
                {
                    negocio.agregar(categoria);
                    MessageBox.Show(" Categoria \n agregada \n con exito");
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            this.Close();
        }

        private void frmAgregarCat_Load(object sender, EventArgs e)
        {
            try
            {
                if(categoria != null)
                {
                    //precargar propiedades para modificar
                    txbNombreCat.Text = categoria.NombreCategoria;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
