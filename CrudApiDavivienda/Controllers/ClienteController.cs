using CrudApiDavivienda.Interfaces;
using CrudApiDavivienda.Models;
using CrudApiDavivienda.Models.ViewModels;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;


namespace CrudApiDavivienda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {

            return _clienteService.CrearListaClientes();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var cliente = _clienteService.ObtenerCliente(_clienteService.CrearListaClientes(), id);
            if (cliente == null)
            {
                return NotFound("Cliente no Encontrado");
            }

            return Ok(cliente);
        }


        [HttpPost]
        public IActionResult Post([FromBody] ClienteViewModel cliente)
        {
            var resultado = _clienteService.AgregarCliente(_clienteService.CrearListaClientes(), cliente);

            return Ok(resultado);
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ClienteViewModel clienteVm)
        {
            var listaClientes = _clienteService.CrearListaClientes();
            var cliente = _clienteService.ObtenerCliente(listaClientes, id);
            if (cliente == null)
            {
                return NotFound("Cliente no Encontrado");
            }
            var resultado = _clienteService.ActualizarCliente(listaClientes, cliente,clienteVm);
            return Ok(resultado);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var listaClientes=_clienteService.CrearListaClientes();
            var cliente = _clienteService.ObtenerCliente(listaClientes, id);
            if (cliente == null)
            {
                return NotFound("Cliente no Encontrado");
            }
            var clienteEliminado=_clienteService.EliminarCliente(listaClientes, cliente);
            return Ok(clienteEliminado);
        }
    }
}
