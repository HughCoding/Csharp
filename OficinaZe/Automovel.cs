public class Automovel : Veiculo
{
    public override void ListarVerificacoes()
    {
        Console.WriteLine("Automóvel: checar pneus, motor e óleo.");
    }

    public override void Ajustar()
    {
        Console.WriteLine("Automóvel: ajustar motor.");
    }

    public override void Limpar()
    {
        Console.WriteLine("Automóvel: lavar carro.");
    }

    public void MudarOleo()
    {
        Console.WriteLine("Automóvel: óleo trocado!");
    }
}