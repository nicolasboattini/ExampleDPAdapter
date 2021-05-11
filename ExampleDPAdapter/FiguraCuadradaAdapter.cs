using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDPAdapter
{
    public class FiguraCuadradaAdapter: FiguraRedonda
    {
        public FiguraCuadrada cuad;
        public FiguraCuadradaAdapter(FiguraCuadrada fig)
        {
            this.cuad = fig;
        }
        public override double GetRadio()
        {            
            return (cuad.GetAncho() * ((Math.Sqrt(2)) / (2)));
        }
    }
}
