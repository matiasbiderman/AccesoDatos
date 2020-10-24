using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Entidades
{
    [DataContract]
    public class Cliente
    {
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private int _id;

        [DataMember]
        public int Id { get => _id; set => _id = value; }

        [DataMember]
        public string Nombre { get => _nombre; set => _nombre = value; }

        [DataMember(Name = "apellido")]
        public string Ape { get => _apellido; set => _apellido = value; }

        public string Direccion { get => _direccion; set => _direccion = value; }

        public override string ToString()
        {
            return string.Format("Cliente {0}, {1}", this._apellido, this._nombre);
        }
    }
}
