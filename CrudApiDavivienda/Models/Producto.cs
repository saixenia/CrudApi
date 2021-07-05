using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApiDavivienda.Models
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioActual { get; set; }
        public int? ProveedorId { get; set; }

        public Producto() { }
        public Producto(int id)
        {
            ProductoId = id;
            Nombre = "julian" + id;
            PrecioActual = 2000.01M * id;
            ProveedorId = id;
        }

    }
}
