using NLayer.Datos;
using NLayer.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Negocio
{
    public class TipoPrestamoServicio
    {
        TipoPrestamoMapper mapper;
        public TipoPrestamoServicio()
        {
            mapper = new TipoPrestamoMapper();
        }
        public List<TipoPrestamo> TraerTipos()
        {
            List<TipoPrestamo> resultado = mapper.TraerTodos();

            return resultado;
        }
    }
}
