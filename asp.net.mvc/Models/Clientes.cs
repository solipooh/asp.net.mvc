using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp.net.mvc.Models
{
    public class Clientes
    {
        public int ID { get; set; }
        
        public string Nombre { get; set; }
        
        public DateTime FechaAlta { get; set; }
        
        public int Edad { get; set; }
    }
}