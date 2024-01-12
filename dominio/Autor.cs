using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Autor
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
