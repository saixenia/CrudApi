using CrudApiDavivienda.Models;
using CrudApiDavivienda.Models.ViewModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApiDavivienda.Interfaces
{
    public interface IProductoService
    {

        List<Producto> CrearListaProductos();
        Producto ObtenerProducto(List<Producto> productos, int id);
        Producto AgregarProducto(List<Producto> productos, ProductoViewModel Producto);
        Producto EliminarProducto(List<Producto> productos, Producto Producto);
        Producto ActualizarProducto(List<Producto> productos, Producto Producto, ProductoViewModel clienteViewModel);
    }
}
