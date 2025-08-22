class Program
{
    static void Main()
    {
        Oficina oficina = new Oficina();

        for (int i = 0; i < 3; i++)
        {
            Veiculo v = oficina.Proximo();
            oficina.Manutencao(v);
            Console.WriteLine("----");
        }
    }
}