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
    public partial class frmAgregarMarca : Form
    {
        private Marca marca=null;

        public frmAgregarMarca()
        {
            InitializeComponent();
        }
        public frmAgregarMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgregarMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Asigna al Enter para poder cambiar de foco (como el Tab)
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Previene el sonido de 'beep'
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if (marca == null)
                    marca = new Marca();

                marca.NombreMarca = txbNombreMarca.Text;

                if(marca.IdMarca != 0)
                {
                    negocio.ModificarMarca(marca);
                    MessageBox.Show("Marca modificada con exito");
                }
                else
                {
                    negocio.agregar(marca);

                    MessageBox.Show("Marca agregada con exito");

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            this.Close();
        }

        private void frmAgregarMarca_Load(object sender, EventArgs e)
        {
            try
            {
                if (marca != null)
                    //precargar propiedades para modificar
                    txbNombreMarca.Text = marca.NombreMarca;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
