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
        public frmAgregarMarca()
        {
            InitializeComponent();
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
            Marca marca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                marca.NombreMarca = txbNombreMarca.Text;

                negocio.agregar(marca);

                MessageBox.Show("Marca agregada con exito");
            }
            catch (Exception ex)
            {

                throw ex;
            }

            this.Close();
        }
    }
}
