public class Bicicleta : Veiculo
{
    public override void ListarVerificacoes()
    {
        Console.WriteLine("Bicicleta: checar corrente e pneus.");
    }

    public override void Ajustar()
    {
        Console.WriteLine("Bicicleta: ajustar marchas.");
    }

    public override void Limpar()
    {
        Console.WriteLine("Bicicleta: limpando guidão e quadro.");
    }
}