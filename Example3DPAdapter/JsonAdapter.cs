using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace Example3DPAdapter
{
    // Adaptador Concreto
    public class JsonAdapter : IAdapter
    {
        private readonly IXmlApiAdaptee xmlApiAdaptee;

        public JsonAdapter(IXmlApiAdaptee xmlApiAdaptee)
        {
            this.xmlApiAdaptee = xmlApiAdaptee;
        }

        public string GetProducts()
        {
            var products = this.xmlApiAdaptee.GetProducts();
            var result = JsonConvert.SerializeObject(products, Formatting.Indented);

            return result;
        }
    }
}
