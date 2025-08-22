class Program
{
    static void Main()
    {
        ContaPoupanca cp = new ContaPoupanca(15);
        cp.Deposito(1000);
        cp.CorrigeSaldo();
        cp.MostraSaldo();
        Console.WriteLine($"Prêmio poupança: {cp.CalculaPremio()}");

        ContaEspecial ce = new ContaEspecial(5000);
        ce.Deposito(2000);
        ce.MostraSaldo();
        Console.WriteLine($"Prêmio conta especial: {ce.CalculaPremio()}");
    }
}