public class Oficina
{
    private Random rnd = new Random();

    public Veiculo Proximo()
    {
        return rnd.Next(2) == 0 ? (Veiculo)new Automovel() : new Bicicleta();
    }

    public void Manutencao(Veiculo v)
    {
        v.ListarVerificacoes();
        v.Ajustar();
        v.Limpar();

        if (v is Automovel auto)
        {
            auto.MudarOleo();
        }
    }
}
