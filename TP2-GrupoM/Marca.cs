using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_GrupoM
{
    internal class Marca
    {
        public int IdMarca { get; set; }
        public string NombreMarca { get; set; }

        public override string ToString()
        {
            return NombreMarca;
        }
    }
}
