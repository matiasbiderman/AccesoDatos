using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Entidades
{
    public class Operador
    {
        private List<Prestamo> prestamos;
        private double comision;
        private double porcentajeComision;

        public Operador(double comision)
        {
            prestamos = new List<Prestamo>();

        }
        public double DefinirComision()
        {
            double interes = 0;
            foreach (Prestamo prestamo in prestamos)
            {
                interes += prestamo.CuotaInteres();
            }
            return interes * 0.15;
        }
    }
}
