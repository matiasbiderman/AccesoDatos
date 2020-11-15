using Newtonsoft.Json;
using NLayer.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Datos
{
    public class PrestamoMapper
    {
        public List<Prestamo> TraerTodos()
        {
            string json2 = WebHelper.Get("/api/v1/prestamos"); // trae un texto en formato json de una web
            List<Prestamo> resultado = MapList(json2);
            return resultado;
        }
        public TransactionResult Insert(Prestamo prestamo)
        {
            NameValueCollection obj = ReverseMap(prestamo);
            string result = WebHelper.Post("/api/v1/prestamos", obj);
            TransactionResult resultadoTransaccion = MapResultado(result);
            return resultadoTransaccion;
        }

        private NameValueCollection ReverseMap(Prestamo prestamo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", prestamo.Id.ToString());
            n.Add("tna", prestamo.Tna.ToString());
            n.Add("linea", prestamo.Linea.ToString());
            n.Add("plazo", prestamo.Plazo.ToString());
            n.Add("monto", prestamo.Monto.ToString());
            //n.Add("cuota", prestamo.Cuota.ToString());
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            return n;

        }

        private List<Prestamo> MapList(string json)
        {
            List<Prestamo> lst = JsonConvert.DeserializeObject<List<Prestamo>>(json);
            return lst;
        }
        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
    }
}
