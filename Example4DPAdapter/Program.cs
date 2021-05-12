using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4DPAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("La interfaz de Adaptee es incompatible con el cliente");
            Console.WriteLine("Pero con adapter el cliente puede llamar a su método");            
            Console.WriteLine(target.GetRequest());
        }
        
    }
}
