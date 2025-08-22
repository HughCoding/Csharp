using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Sandbox
{
    public class Airport : IFlyingTransport
    {
        IFlyingTransport Vehicle {  get; set; }

        public bool Accept(IFlyingTransport flying, string origin, string destination, int passengers)
        {
         if(Vehicle != null)
            {
                Console.WriteLine("Unavailable airport.");
                return false;
            }

         Vehicle = flying;
         Vehicle.Fly(origin, destination, passengers);
         return true;
            
        }

        public void Clean()
        {
            Vehicle = null;

        }

        public void Fly(string origin, string destination, int passengers)
        {
            throw new NotImplementedException();
        }
    }
}

