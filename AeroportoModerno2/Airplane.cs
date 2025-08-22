using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Airplane : IFlyingTransport
    {
        public void Fly(string origin, string destination, int passengers)
        {
            Console.WriteLine($"Airplane flying from {origin} to {destination} with {passengers} passengers.");
        }
    }
}
