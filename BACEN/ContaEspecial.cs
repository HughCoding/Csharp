public class ContaEspecial : ContaDeBanco, Capitalizacao
{
    private double limite;

    public ContaEspecial(double limite)
    {
        this.limite = limite;
    }

    public double CalculaPremio()
    {
        return limite * 0.05;
    }
}