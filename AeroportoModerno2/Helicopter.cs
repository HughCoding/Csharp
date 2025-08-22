using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Helicopter : IFlyingTransport
    {
        public void Fly(string origin, string destination, int passengers)
        {
            Console.WriteLine($"Helicopter flying from {origin} to {destination} with {passengers} passengers.");
        }
    }
}
