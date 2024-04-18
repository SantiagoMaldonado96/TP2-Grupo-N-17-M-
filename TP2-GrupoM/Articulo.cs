﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_GrupoM
{
    internal class Articulo
    {
        //Los datos mínimos con los que deberá contar el artículo son los siguientes:

        public int CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string Imagen { get; set; }
        public float Precio { get; set; }
    }
}
