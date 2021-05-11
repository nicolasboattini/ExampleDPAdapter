using System;

namespace ExampleDPAdapter
{
    public class HuecoRedondo
    {
        public double radio;
        public HuecoRedondo()
        {

        }
        public HuecoRedondo(double rad)
        {
            this.radio = rad;
        }
        public double GetRadio()
        {
            return this.radio;
        }
        public bool Encaja(FiguraRedonda fig)
        {
            return (this.GetRadio() >= fig.GetRadio());
        }
    }
}
