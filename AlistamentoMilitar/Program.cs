class Program
{
    static void Main()
    {
        Militar[] tropa = { new Marinha(), new Exercito(), new Aeronautica() };
        Treinamento treino = new Treinamento();
        treino.Treinar(tropa);
    }
}