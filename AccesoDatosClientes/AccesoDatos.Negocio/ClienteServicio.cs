using AccesoDatos.Datos;
using AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Negocio
{
    class ClienteServicio
    {
        private ClienteMapper mapper;
        public ClienteServicio()
        {
            mapper = new ClienteMapper();
        }

        public List<Cliente> TraerClientes()
        {
            List<Cliente> result = mapper.TraerTodos();
            return result;
        }

        public Cliente TraerClientesPorId(int id)
        {
            List<Cliente> result = mapper.TraerTodos();
            Cliente cli = null;
            foreach (Cliente c in result)
            {
                if (c.Id == id)
                    cli = c;
            }
            return cli;

        }

        public int InsertarCliente(string nombre, string apellido, string direccion)
        {
            // antes validar con el get si existe ese dni/apellido-nombre
            List<Cliente> result = mapper.TraerTodos();

            Cliente cliente = new Cliente();
            cliente.Ape = apellido;
            cliente.Nombre = nombre;
            cliente.Direccion = direccion;

            foreach (var item in result)
            {
                if (item.ToString() == cliente.ToString())
                    throw new Exception("El cliente ya existe");
            }

            // ya pasamos las validaciones, persistimos el cliente
            TransactionResult resultante = mapper.Insert(cliente);

            if (resultante.IsOk)
                return resultante.Id;
            //return TraerClientesPorId(resultante.Id);
            else

                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);

        }
    }
}
