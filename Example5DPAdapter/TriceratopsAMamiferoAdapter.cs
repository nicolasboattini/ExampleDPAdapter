using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5DPAdapter
{
    public class TriceratopsAMamiferoAdapter : IMamifero
    {
        private readonly Triceratops triceratops;

        public TriceratopsAMamiferoAdapter(Triceratops triceratops)
        {
            this.triceratops = triceratops;
        }

        public IHijo DarNacimiento()
        {
            HuevoTriceratops huevo = triceratops.DejarHuevo();

            IHijo hijo = huevo.Incubar();

            return hijo;
        }
    }
}
