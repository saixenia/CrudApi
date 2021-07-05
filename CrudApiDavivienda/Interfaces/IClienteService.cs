using CrudApiDavivienda.Models;
using CrudApiDavivienda.Models.ViewModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApiDavivienda.Interfaces
{
    public interface IClienteService
    {
        List<Cliente> CrearListaClientes();
        Cliente ObtenerCliente(List<Cliente> clientes, int id);
        Cliente AgregarCliente(List<Cliente> clientes, ClienteViewModel cliente);
        Cliente EliminarCliente(List<Cliente> clientes, Cliente cliente);
        Cliente ActualizarCliente(List<Cliente> clientes, Cliente cliente,ClienteViewModel clienteViewModel);

    }
}
