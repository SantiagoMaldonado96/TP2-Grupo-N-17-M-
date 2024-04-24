using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        //Los datos mínimos con los que deberá contar el artículo son los siguientes:

        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Cat { get; set; }
        public Imagen Imagen { get; set; }
        public float Precio { get; set; }
    }
}
