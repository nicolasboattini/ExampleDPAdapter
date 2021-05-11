using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5DPAdapter
{
    public static class ChildCreator
    {
        public static IChild CreateChild(IMammal mammal)
        {
            return mammal.GiveBirth();
        }
    }
}
