using CrudApiDavivienda.Interfaces;
using CrudApiDavivienda.Models;
using CrudApiDavivienda.Models.ViewModels;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApiDavivienda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _productoService;
        public ProductoController(IProductoService productoService)
        {
            _productoService = productoService;

        }

        [HttpGet]
        public IEnumerable<Producto> Get()
        {
            return _productoService.CrearListaProductos();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var producto = _productoService.ObtenerProducto(_productoService.CrearListaProductos(), id);
            if (producto == null)
            {
                return NotFound("Producto no Encontrado");
            }

            return Ok(producto);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ProductoViewModel producto)
        {
            var resultado = _productoService.AgregarProducto(_productoService.CrearListaProductos(), producto);

            return Ok(resultado);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ProductoViewModel productoVm)
        {
            var listaProductos = _productoService.CrearListaProductos();
            var producto = _productoService.ObtenerProducto(listaProductos, id);
            if (producto == null)
            {
                return NotFound("Producto no Encontrado");
            }
            var resultado = _productoService.ActualizarProducto(listaProductos, producto, productoVm);
            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var listaProductos = _productoService.CrearListaProductos();
            var producto = _productoService.ObtenerProducto(listaProductos, id);
            if (producto == null)
            {
                return NotFound("Producto no Encontrado");
            }
            var clienteEliminado = _productoService.EliminarProducto(listaProductos, producto);
            return Ok(clienteEliminado);
        }
    }
}
