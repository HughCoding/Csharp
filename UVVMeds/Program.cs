class Program
{
    static void Main()
    {
        Produto p1 = new Produto("Remédio A");
        Ingrediente i1 = new Ingrediente("Paracetamol");
        Ingrediente i2 = new Ingrediente("Cafeína");

        p1.AdicionarIngrediente(i1);
        p1.AdicionarIngrediente(i2);

        p1.MostrarIngredientes();
    }
}