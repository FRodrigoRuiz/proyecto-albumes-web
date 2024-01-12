using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class AlbumNegocio
    {
        public List<Album> listar()
        {
            List<Album> lista = new List<Album>();
            AccesoDatos datos = new AccesoDatos();

            datos.setearConsulta("Select Nombre, Canciones, FechaCreacion, AU.Descripcion Autor, G.Descripcion Genero, ImagenUrl, Precio, A.IdAutor, A.IdGenero, A.Id From ALBUMES A, AUTORES AU, GENEROS G Where AU.Id = A.IdAutor And G.Id = A.IdGenero");
            datos.ejecutarLectura();

            try
            {
                while (datos.Lector.Read())
                {
                    Album aux = new Album();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Canciones = (string)datos.Lector["Canciones"];
                    aux.FechaCreacion = (int)datos.Lector["FechaCreacion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    aux.Autor = new Autor();
                    aux.Autor.Id = (int)datos.Lector["IdAutor"];
                    aux.Autor.Descripcion = (string)datos.Lector["Autor"];

                    aux.Genero = new Genero();
                    aux.Genero.Id = (int)datos.Lector["IdGenero"];
                    aux.Genero.Descripcion = (string)datos.Lector["Genero"];

                    lista.Add(aux);
                }

                return lista;
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

        public void agregar(Album nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into ALBUMES (Nombre, Canciones, FechaCreacion, IdAutor, IdGenero, ImagenUrl, Precio) Values(@nombre, @canciones, @fechaCreacion, @idAutor, @idGenero, @imagenUrl, @precio)");
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@canciones", nuevo.Canciones);
                datos.setearParametro("@fechaCreacion", nuevo.FechaCreacion);
                datos.setearParametro("@idAutor", nuevo.Autor.Id);
                datos.setearParametro("@idGenero", nuevo.Genero.Id);
                datos.setearParametro("@imagenUrl", nuevo.ImagenUrl);
                datos.setearParametro("@precio", nuevo.Precio);
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

        public void modificar(Album album)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Update ALBUMES set Nombre = @nombre, Canciones = @canciones, FechaCreacion = @fechaCreacion, IdAutor = @idAutor, IdGenero = @idGenero, ImagenUrl = @imagenUrl, Precio = @precio Where Id = @id");
                datos.setearParametro("@nombre", album.Nombre);
                datos.setearParametro("@canciones", album.Canciones);
                datos.setearParametro("@fechaCreacion", album.FechaCreacion);
                datos.setearParametro("@idAutor", album.Autor.Id);
                datos.setearParametro("@idGenero", album.Genero.Id);
                datos.setearParametro("@imagenUrl", album.ImagenUrl);
                datos.setearParametro("@precio", album.Precio);

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
    }
}
