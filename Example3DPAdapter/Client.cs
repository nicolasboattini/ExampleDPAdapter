using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Example3DPAdapter
{
    public class Client
    {
        private readonly IAdapter adapter;

        public Client(IAdapter adapter)
        {
            this.adapter = adapter;
        }

        public string GetProducts()
        {
            var products = this.adapter.GetProducts();

            return products;
        }
    }
}

