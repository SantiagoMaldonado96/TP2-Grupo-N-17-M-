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
    public partial class Articulos : Form
    {
        public Articulos()
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
    }
}
