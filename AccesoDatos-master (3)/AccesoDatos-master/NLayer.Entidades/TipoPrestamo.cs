using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Entidades
{
    [DataContract]
    public class TipoPrestamo
    {
        private string _linea;
        private double _tna;

        [DataMember]
        public string Linea { get => _linea; set => _linea = value; }

        [DataMember]
        public double Tna { get => _tna; set => _tna = value; }
        public override string ToString()
        {
            return _linea + " TNA: " + _tna + "%";
        }
    }
}
