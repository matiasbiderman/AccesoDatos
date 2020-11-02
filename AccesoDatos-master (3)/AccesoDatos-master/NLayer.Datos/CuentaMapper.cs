using Newtonsoft.Json;
using NLayer.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Datos
{
    public class CuentaMapper
    {
        public List<Cuenta> TraerCuentas()
        {
            string json2 = WebHelper.Get("/cuenta");
            return MapList(json2);
        }
        /*public Cuenta Traer(int idCliente)
        {
            string json2 = WebHelper.Get("/cuenta/" + idCliente.ToString()); // trae un texto en formato json de una web
            Cuenta resultado = Map(json2);
            return resultado;
        }*/
        private Cuenta Map(string json2)
        {
            Cuenta lst = JsonConvert.DeserializeObject<Cuenta>(json2);
            return lst;
        }
        private List<Cuenta> MapList(string json)
        {
            //devuelve el json deserializado
            return JsonConvert.DeserializeObject<List<Cuenta>>(json);
        }
        public TransactionResult Update(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMap(cuenta, "update");

            string result = WebHelper.Post("/cuenta", obj);

            TransactionResult resultadoTransaccion = MapResultado(result);

            return resultadoTransaccion;
        }

        public TransactionResult Insert(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMap(cuenta, "insert");
            string result = WebHelper.Post("/cuenta", obj);
            return MapResultado(result);
            //devuelve el resultado de la transaccion
        }

        private NameValueCollection ReverseMap(Cuenta cuenta, string tipo)
        {

            NameValueCollection n = new NameValueCollection();

            if (tipo == "insert")
            {
                n.Add("idCliente", cuenta.IdCliente.ToString());
                n.Add("Descripcion", cuenta.Descripcion);
            }
            else if (tipo == "update")
            {
                n.Add("id", cuenta.Id.ToString());
                n.Add("Saldo", cuenta.Saldo.ToString());
            }

            return n;
        }
        
        private TransactionResult MapResultado(string json)
        {
            return JsonConvert.DeserializeObject<TransactionResult>(json);
            //devuelve el resultado
        }
    }
}
