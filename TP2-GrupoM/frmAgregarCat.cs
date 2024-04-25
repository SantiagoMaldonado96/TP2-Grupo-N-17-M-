﻿using System;
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
        public frmAgregarCat()
        {
            InitializeComponent();
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
            Categoria categoria = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                categoria.NombreCategoria = txbNombreCat.Text;

                negocio.agregar(categoria);

                MessageBox.Show(" Categoria \n agregada \n con exito");
            }
            catch (Exception ex)
            {

                throw ex;
            }
            this.Close();
        }
    }
}
