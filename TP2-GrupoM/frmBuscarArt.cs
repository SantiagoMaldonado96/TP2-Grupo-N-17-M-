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
    public partial class frmBuscarArt : Form
    {
        public frmBuscarArt()
        {
            InitializeComponent();
        }

        private void btnCancelarBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
