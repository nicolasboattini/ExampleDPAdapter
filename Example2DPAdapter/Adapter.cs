using System;

namespace Example2DPAdapter
{
    public class Adapter: Target
    {
        private Adaptee _adaptee = new Adaptee();

        public override void Request()
        {         
            _adaptee.SpecificRequest();
        }
    }
}
