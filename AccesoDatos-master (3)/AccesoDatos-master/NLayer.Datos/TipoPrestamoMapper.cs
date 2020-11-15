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
    public class TipoPrestamoMapper
    {
        public List<TipoPrestamo> TraerTodos()
        {
            string json2 = WebHelper.Get("/api/v1/prestamotipo"); // trae un texto en formato json de una web
            List<TipoPrestamo> resultado = MapList(json2);
            return resultado;
        }
       
        private NameValueCollection ReverseMap(TipoPrestamo tipoPrestamo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("tna", tipoPrestamo.Tna.ToString());
            n.Add("linea", tipoPrestamo.Linea.ToString());
           // n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            return n;
        }

        private List<TipoPrestamo> MapList(string json)
        {
            List<TipoPrestamo> lst = JsonConvert.DeserializeObject<List<TipoPrestamo>>(json);
            return lst;
        }
        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
    }
}
