namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Airport a1 = new Airport();

            IFlyingTransport helicoper = new Helicopter();
            IFlyingTransport airplane = new Airplane();
            IFlyingTransport grypon = new DomesticatedGrypon();

            a1.Accept(helicoper, "Amsterdã", "New York", 12);
            a1.Accept(airplane, "Japan", "Canada", 23);
            a1.Accept(grypon, "Chile", "Brazil", 16);
        }
    }
}
