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
    public partial class frmModificarArticulo : Form
    {
        public frmModificarArticulo()
        {
            InitializeComponent();

            
        }

        private void btnCancelarAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            frmVentanaListarArticulos frmArticulos = Owner as frmVentanaListarArticulos;

            //Pasar los valores de los campos Modificados al articulo seleccionado en lwArticulos

            this.Close();
        }

        private void frmModificarArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Asigna al Enter para poder cambiar de foco (como el Tab)
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Previene el sonido de 'beep'
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }
    }
}
