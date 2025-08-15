using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class ProfDE : Professor

    {
        public override void calcularBeneficio()
        {
            Console.WriteLine($"seu beneficio é de: {getBeneficio}");
        }



    }
}
