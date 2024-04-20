﻿using System;
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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            frmAgregarCat ventana = new frmAgregarCat();
            ventana.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {
            EliminarCategoria ventana = new EliminarCategoria();
            ventana.ShowDialog();
        }
    }
}
