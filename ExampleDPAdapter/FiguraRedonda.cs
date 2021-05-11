using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDPAdapter
{
    public class FiguraRedonda
    {
        public double radio;
        public FiguraRedonda()
        {

        }
        public FiguraRedonda(double rad)
        {
            this.radio = rad;
        }
        public virtual double GetRadio()
        {
            return this.radio;
        }

    }
}
