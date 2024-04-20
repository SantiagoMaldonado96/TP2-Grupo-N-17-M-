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
    public partial class frmVentanaListarArticulos : Form
    {

        public frmVentanaListarArticulos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArt ventana = new frmAgregarArt();
            ventana.ShowDialog();
        }

        private void frmVentanaListarArticulos_Load(object sender, EventArgs e)
        {

        }

        private void btnModificarArt_Click(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           
        }
    }
}
