using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Entidades
{
    [DataContract]
    public class Prestamo
    {
        private string _linea;
        private double _tna;
        private double _monto;
        private string _usuario;
        private double _cuota;
        private int _id;
        private int _plazo;

        public Prestamo(int id, double tna, string linea, int plazo, double monto, double cuota)
        {
            this._id = id;
            this._tna = tna;
            this._linea = linea;
            this._monto = monto;
            this._plazo = plazo;
            this._cuota = cuota;
           // _usuario = "891830";
        }

        [DataMember]
        public int Id { get => _id; set => _id = value; }
        [DataMember]
        public double Tna { get => _tna; set => _tna = value; }
        [DataMember]
        public double Cuota { get => CuotaTotal(); set => _cuota = value; }
        [DataMember(Name = "linea")]
        public string Linea { get => _linea; set => _linea = value; }
        [DataMember]
        public int Plazo { get => _plazo; set => _plazo = value; }
        [DataMember]
        public double Monto { get => _monto; set => _monto = value; }
        [DataMember]
        public string Usuario { get => _usuario; set => _usuario = value; }
        public double CuotaCapital()
        {
            return this._monto/this._plazo;
        }
        public double CuotaInteres()
        {
            return CuotaCapital() * this._tna/12/100;
        }
        public double CuotaTotal()
        {
            return CuotaCapital() + CuotaInteres();
        }
        public override string ToString()
        {
            return string.Format("Id{0},$Monto{1},TNA{2}%, Linea{3}, $Cuota{4} Plazo{5}", this._id,this.Monto, this.Tna, this.Linea, this._cuota, this.Plazo/*, this._usuario*/);
        }
    }
}
