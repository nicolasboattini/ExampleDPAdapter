using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5DPAdapter
{
    public static class CreadorDeHijo
    {
        public static IHijo CrearHijo(IMamifero mamífero)
        {
            return mamífero.DarNacimiento();
        }
    }
}
