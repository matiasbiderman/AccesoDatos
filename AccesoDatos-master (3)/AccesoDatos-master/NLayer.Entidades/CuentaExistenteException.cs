using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Entidades
{
    public class CuentaExistenteException : Exception
    {
        public CuentaExistenteException(int id) : base("Ya existe la cuenta con id " + id) { }
    }
}
