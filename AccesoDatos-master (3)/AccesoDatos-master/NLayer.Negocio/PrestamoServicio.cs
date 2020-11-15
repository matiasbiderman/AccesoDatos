using NLayer.Datos;
using NLayer.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Negocio
{
    public class PrestamoServicio
    {
        PrestamoMapper mapper;
        public PrestamoServicio()
        {
            mapper = new PrestamoMapper();
        }
        public void AgregarPrestamo(Prestamo prestamo)
        {
            TransactionResult t = mapper.Insert(prestamo);
            if (!t.IsOk)
            {
                throw new Exception("error al ingresar un prestamo.Detalle " + t.Error);
            }
        }
        public List<Prestamo> TraerPrestamos()
        {
            List<Prestamo> resultado = mapper.TraerTodos();

            return resultado;
        }
        public int ProximoId()
        {
            List<Prestamo> c = TraerPrestamos();
            return c.Max(prestamo => prestamo.Id) + 1;
        }
    }
}
