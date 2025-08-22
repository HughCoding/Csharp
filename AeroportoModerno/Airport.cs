using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Sandbox
{
    public class Airport
    {
        public void Accept(IFlyingTransport vehicle, string origin, string destination, int passengers) {

            vehicle.Fly(origin, destination, passengers);
        }
    }
}


