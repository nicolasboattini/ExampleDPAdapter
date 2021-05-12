using System;

namespace Example4DPAdapter
{
    public class Adapter: ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"Este es '{this._adaptee.GetSpecificRequest()}'";
        }
    }
}
