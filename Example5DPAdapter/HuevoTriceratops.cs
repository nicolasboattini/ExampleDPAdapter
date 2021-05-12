using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5DPAdapter
{
    public class HuevoTriceratops
    {
        public IHijo Incubar()
        {
            return new TriceratopsHijo();
        }
    }
}
