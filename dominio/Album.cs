using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    internal class Album
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Canciones { get; set; }
        public int FechaCreacion { get; set; }
        public Autor Autor { get; set; }
        public Genero Genero { get; set; }
        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; }
    }
}
