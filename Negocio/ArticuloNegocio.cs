using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Net;
using System.Data;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, Precio, ImagenUrl from ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I where A.IdMarca = M.Id and A.IdCategoria = C.Id and A.Id = I.IdArticulo");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    //Marca marca = new Marca(); 
                    //Imagen imagen = new Imagen();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.CodigoArticulo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.NombreMarca = (string)datos.Lector["Marca"];
                    aux.Cat = new Categoria();  
                    aux.Cat.NombreCategoria = (string)datos.Lector["Categoria"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Imagen = new Imagen();
                    aux.Imagen.UrlImagen = (string)datos.Lector["ImagenUrl"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }

            finally 
            {
                datos.cerrarConexion();
            }
        }        

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) values (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@Precio)");
                datos.setearParametro("@Codigo", nuevo.CodigoArticulo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.Marca.IdMarca);
                datos.setearParametro("@IdCategoria", nuevo.Cat.IdCategoria);
                datos.setearParametro("@Precio", nuevo.Precio);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            { 
                datos.cerrarConexion();
            }

        }

        public int buscarId(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            int Id;
            string codigo = art.CodigoArticulo.ToString();
            datos.setearConsulta("select id from ARTICULOS where Codigo = '"+codigo+"'");
            
            datos.ejecutarLectura();

            datos.Lector.Read();
            Id = (int)datos.Lector["id"];
                
            

            return Id;
        }

        public void eliminarArticulo(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("Delete From Articulos Where Id = @Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool buscarIdCategoria(int idCategoria)
        {
            List<int> lista = new List<int>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select IdMarca from ARTICULOS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    int valor;

                    valor = (int)datos.Lector["IdMarca"];
                    lista.Add(valor);
                }

                foreach (int item in lista)
                {
                    if(item == idCategoria)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
