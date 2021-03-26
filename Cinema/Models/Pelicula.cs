using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cinema.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Genero { get; set; }
        public String AnioLanzamiento { get; set; }
        public String Mes { get; set; }
        public String Clasificacion { get; set; }
    }
}