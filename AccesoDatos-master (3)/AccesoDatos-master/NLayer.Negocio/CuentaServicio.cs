using NLayer.Datos;
using NLayer.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Negocio
{
    public class CuentaServicio
    {
        private CuentaMapper mapper;
        ClienteServicio clienteServicio;

        public CuentaServicio()
        {
            mapper = new CuentaMapper();
            clienteServicio = new ClienteServicio();
        }
        public List<Cuenta> TraerCuentas()
        {
            return mapper.TraerCuentas();
        }
        public Cuenta Traer(int idCliente)
        {
            Cuenta result = mapper.Traer(idCliente);
            return result;
        }
        public void IngresarCuenta(Cuenta cuenta)
        {
            if (!ExisteLaCuenta(cuenta))
            {
                TransactionResult result = mapper.Insert(cuenta);
                if (!result.IsOk)
                    throw new Exception("Hubo un error en la petición al servidor. Detalle: " + result.Error);
                else
                {
                    mapper.Insert(cuenta);
                }
            }
            else
            {
                throw new CuentaExistenteException(cuenta.Id);
            }
        }
        public void ModificarSaldo(int saldo, int idcliente)
        {
            if (saldo > 0)
            {
                
                Traer(idcliente).Saldo = saldo;

            }
            else
            {
                throw new Exception("el saldo es negativo");
            }
        }

        /*public Cuenta AbrirCuenta(string descripcion, int idCliente)
        {
            if (clienteServicio.Existe(idCliente))
            {
                Cuenta c = new Cuenta();
                c.IdCliente = idCliente;
                c.Descripcion = descripcion;

                TransactionResult t = mapper.Insert(c);

                if (t.IsOk)
                {
                    return Traer(idCliente);
                }
                else
                {
                    throw new Exception("Error al abrir la cuenta. " + t.Error);
                }
            }
            else
            {
                throw new Exception("El cliente no existe.");
            }
        }*/
        public bool ExisteLaCuenta(Cuenta cuenta)
        {
            List<Cuenta> cuentas = TraerCuentas();
            return cuentas.Any(c => c.Equals(cuenta));
        }
        public int ProximoId()
        {
            List<Cuenta> c = TraerCuentas();
            return c.Max(cuenta => cuenta.Id) + 1;
        }
        public int ProximoIdCuenta()
        {
            List<Cuenta> c = TraerCuentas();
            return c.Max(cuenta => cuenta.NroCuenta) + 1;
        }
    }
}
