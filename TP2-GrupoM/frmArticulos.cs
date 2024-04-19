using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_GrupoM
{
    public partial class frmArticulos : Form
    {
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void Articulos_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //Se podria crear alguna funcion, pasando el  tipo, para poder replicar en otras ventanas
            foreach (var item in Application.OpenForms)     
            {
                if(item.GetType() == typeof(frmVentanaListarArticulos))
                {
                    MessageBox.Show("Ventana ya abierta");
                    return;
                }
            }
            frmVentanaListarArticulos ventanaListarArticulos = new frmVentanaListarArticulos();
            ventanaListarArticulos.Show();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArt ventana = new frmAgregarArt();
            ventana.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarArt ventana = new frmBuscarArt();
            ventana.ShowDialog();
        }
    }
}
