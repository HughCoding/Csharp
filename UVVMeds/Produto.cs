public class Produto
{
    public string Nome { get; set; }
    public List<Ingrediente> Ingredientes { get; set; } = new List<Ingrediente>();

    public Produto(string nome) => Nome = nome;

    public void AdicionarIngrediente(Ingrediente i)
    {
        Ingredientes.Add(i);
    }

    public void MostrarIngredientes()
    {
        Console.WriteLine($"Produto {Nome} contém:");
        foreach (var i in Ingredientes)
        {
            Console.WriteLine($"- {i.Nome}");
        }
    }
}