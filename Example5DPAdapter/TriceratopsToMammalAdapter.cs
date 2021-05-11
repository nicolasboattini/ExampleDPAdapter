using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5DPAdapter
{
    public class TriceratopsToMammalAdapter : IMammal
    {
        private readonly Triceratops triceratops;

        public TriceratopsToMammalAdapter(Triceratops triceratops)
        {
            this.triceratops = triceratops;
        }

        public IChild GiveBirth()
        {
            TriceratopsEgg egg = triceratops.LayEgg();

            IChild child = egg.Hatch();

            return child;
        }
    }
}
