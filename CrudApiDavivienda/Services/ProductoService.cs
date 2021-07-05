using CrudApiDavivienda.Interfaces;
using CrudApiDavivienda.Models;
using CrudApiDavivienda.Models.ViewModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApiDavivienda.Services
{
    public class ProductoService : IProductoService
    {
        public List<Producto> CrearListaProductos()
        {
            var Productos = new List<Producto>();
            Productos.Add(new Producto(1));
            Productos.Add(new Producto(2));
            Productos.Add(new Producto(3));
            Productos.Add(new Producto(4));
            Productos.Add(new Producto(5));
            Productos.Add(new Producto(6));
            Productos.Add(new Producto(7));
            Productos.Add(new Producto(8));
            Productos.Add(new Producto(9));

            return Productos;
        }

        public Producto ObtenerProducto(List<Producto> productos, int id)
        {

            return productos.Find(c => c.ProductoId == id);
        }

        public Producto AgregarProducto(List<Producto> productos, ProductoViewModel productoVm)
        {
            var producto = MapearAProducto(productoVm);
            producto.ProductoId = productos.Count + 1;
            productos.Add(producto);

            return productos.Last();
        }

        private Producto MapearAProducto(ProductoViewModel productoVm)
        {
            var producto = new Producto() { Nombre = productoVm.Nombre, PrecioActual = productoVm.PrecioActual };
            return producto;
        }

        public Producto EliminarProducto(List<Producto> productos, Producto producto)
        {
            productos.Remove(producto);

            return producto;
        }

        public Producto ActualizarProducto(List<Producto> productos, Producto producto, ProductoViewModel productoViewModel)
        {
            var productoActualizar = productos.Find(c => c.Equals(producto));
            if (productoActualizar.PrecioActual != productoViewModel.PrecioActual)
            {
                productoActualizar.PrecioActual = productoViewModel.PrecioActual;
            }
            if (productoActualizar.Nombre != productoViewModel.Nombre)
            {
                productoActualizar.Nombre = productoViewModel.Nombre;
            }

            return productoActualizar;

        }
    }
}
