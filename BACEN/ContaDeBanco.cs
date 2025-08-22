public class ContaDeBanco
{
    protected double saldo;

    public void Deposito(double valor)
    {
        saldo += valor;
    }

    public void Retirada(double valor)
    {
        saldo -= valor;
    }

    public void MostraSaldo()
    {
        Console.WriteLine($"Saldo atual: {saldo:C}");
    }
}