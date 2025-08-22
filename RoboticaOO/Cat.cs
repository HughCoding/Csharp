public class Cat : Animal, FourLegged, OxygenBreather
{
    public void Run(string destination)
    {
        Console.WriteLine($"O gato correu para {destination}!");
    }

    public void Breath()
    {
        Console.WriteLine("O gato respira oxigênio");
    }
}