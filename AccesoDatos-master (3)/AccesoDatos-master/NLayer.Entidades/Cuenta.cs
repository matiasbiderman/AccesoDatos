using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Entidades
{
    [DataContract]
    public class Cuenta
    {
        [DataMember]
        private int nroCuenta;
        [DataMember]
        private string descripcion;
        [DataMember]
        private int saldo;
        [DataMember]
        private DateTime fechaApertura;
        [DataMember]
        private DateTime fechaModificacion;
        [DataMember]
        private bool activo;
        [DataMember]
        private int idCliente;
        [DataMember]
        private int id;

        public Cuenta()
        {

        }
        public Cuenta(int nroCuenta, string descripcion, int saldo, DateTime fechaApertura, DateTime fechaModificacion, bool activo, int idCliente, int id)
        {
            this.nroCuenta = nroCuenta;
            this.descripcion = descripcion;
            this.saldo = saldo;
            this.activo = activo;
            this.idCliente = idCliente;
            this.id = id;
            this.fechaApertura = fechaApertura;
            this.fechaModificacion = fechaModificacion;
        }
        public Cuenta(int nroCuenta, string descripcion, int idCliente)
        {
            this.nroCuenta = nroCuenta;
            this.descripcion = descripcion;
            this.saldo = 0;
            this.activo = true;
            this.idCliente = idCliente;
            //this.id = id;
            this.fechaApertura = DateTime.Now;
            this.fechaModificacion = DateTime.Now;
        }
        public int NroCuenta
        {
            get
            {
                return this.nroCuenta;
            }
            set
            {
                this.nroCuenta = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }
        public int Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                this.saldo = value;
            }
        }
        public bool Activo
        {
            get
            {
                return this.activo;
            }
            set
            {
                this.activo = value;
            }
        }
        public DateTime FechaApertura
        {
            get
            {
                return this.fechaApertura;
            }
            set
            {
                this.fechaApertura = value;
            }
        }
        public DateTime FechaModificacion
        {
            get
            {
                return this.fechaModificacion;
            }
            set
            {
                this.fechaModificacion = value;
            }
        }
        public int IdCliente
        {
            get
            {
                return this.idCliente;
            }
            set
            {
                this.idCliente = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public override string ToString()
        {
            return nroCuenta + " " + descripcion + " " + idCliente;
        }
    }
}
