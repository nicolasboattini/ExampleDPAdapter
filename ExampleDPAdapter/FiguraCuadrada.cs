using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDPAdapter
{
    public class FiguraCuadrada
    {
        public double ancho;
        
        public FiguraCuadrada(double anch)
        {
            this.ancho = anch;
        }
        public double GetAncho()
        {
            return this.ancho;
        }
    }
}
