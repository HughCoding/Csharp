namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Airport a1 = new Airport();
            DomesticatedGrypon dg1 = new DomesticatedGrypon();
            Airplane air1 = new Airplane();
            Helicopter h1 = new Helicopter();

            
            a1.Accept(air1, "Japan", "Canada", 23);
            a1.Accept(dg1, "Chile", "Brazil", 16);
            a1.Clean();
            a1.Accept(h1, "Amsterdã", "New York", 12);
        }
    }
}