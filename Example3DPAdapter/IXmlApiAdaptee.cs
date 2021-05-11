using System;
using System.Xml.Linq;

namespace Example3DPAdapter
{
    public interface IXmlApiAdaptee
    {
        XDocument GetProducts();
    }
}
