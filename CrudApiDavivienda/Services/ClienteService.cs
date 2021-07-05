using CrudApiDavivienda.Interfaces;
using CrudApiDavivienda.Models;
using CrudApiDavivienda.Models.ViewModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApiDavivienda.Services
{
    public class ClienteService : IClienteService
    {

        public List<Cliente> CrearListaClientes()
        {
            var Clientes = new List<Cliente>();
            Clientes.Add(new Cliente(1));
            Clientes.Add(new Cliente(2));
            Clientes.Add(new Cliente(3));
            Clientes.Add(new Cliente(4));
            Clientes.Add(new Cliente(5));
            Clientes.Add(new Cliente(6));
            Clientes.Add(new Cliente(7));
            Clientes.Add(new Cliente(8));
            Clientes.Add(new Cliente(9));

            return Clientes;
        }

        public Cliente ObtenerCliente(List<Cliente> clientes, int id)
        {

            return clientes.Find(c => c.ClienteId == id);
        }

        public Cliente AgregarCliente(List<Cliente> clientes, ClienteViewModel clienteVm)
        {
            var cliente = MapearACliente(clienteVm);
            cliente.ClienteId = clientes.Count + 1;
            clientes.Add(cliente);

            return clientes.Last();
        }

        private Cliente MapearACliente(ClienteViewModel clienteVm)
        {
            var cliente = new Cliente() { NumeroIdentificacion = clienteVm.NumeroIdentificacion, Direccion = clienteVm.Direccion, Nombre = clienteVm.Nombre, Telefono = clienteVm.Telefono };
            return cliente;
        }

        public Cliente EliminarCliente(List<Cliente> clientes, Cliente cliente)
        {
            clientes.Remove(cliente);

            return cliente;
        }

        public Cliente ActualizarCliente(List<Cliente> clientes, Cliente cliente,ClienteViewModel clienteViewModel)
        {
            var clienteActualizar= clientes.Find(c=> c.Equals(cliente));
            if (clienteActualizar.Direccion != clienteViewModel.Direccion)
            {
                clienteActualizar.Direccion = clienteViewModel.Direccion;
            }
            if (clienteActualizar.Nombre != clienteViewModel.Nombre)
            {
                clienteActualizar.Nombre = clienteViewModel.Nombre;
            }
            if (clienteActualizar.NumeroIdentificacion != clienteViewModel.NumeroIdentificacion)
            {
                clienteActualizar.NumeroIdentificacion = clienteViewModel.NumeroIdentificacion;
            }
            if (clienteActualizar.Telefono != clienteViewModel.Telefono)
            {
                clienteActualizar.Telefono = clienteViewModel.Telefono;
            }

            return clienteActualizar;

        }
    }
}
