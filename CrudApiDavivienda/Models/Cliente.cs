using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApiDavivienda.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Cliente(int id)
        {
            ClienteId = id;
            NumeroIdentificacion = "identificacion" + id;
            Nombre = "julian" + id;
            Direccion = "call";
            Telefono = "3" + id;

        }
        public Cliente() { }
    }
}
