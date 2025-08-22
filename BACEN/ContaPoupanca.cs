public class ContaPoupanca : ContaDeBanco, Capitalizacao
{
    private int diaAniversario;
    private double correcao = 0.02; 

    public ContaPoupanca(int dia)
    {
        this.diaAniversario = dia;
    }

    public void CorrigeSaldo()
    {
        saldo += saldo * correcao;
    }

    public double CalculaPremio()
    {
        return saldo * 0.01;
    }
}