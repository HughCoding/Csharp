
public class PesoIdealPrincipal
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Cálculo de Peso Ideal ===");
        Console.Write("Digite o sexo (M/F): ");
        string sexo = Console.ReadLine();

        Console.Write("Digite a altura: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        PesoIdealPessoa pessoa;

        if (sexo == "M")
        {
            pessoa = new PesoIdealHomem();
        }
        else if (sexo == "F")
        {
            pessoa = new PesoIdealMulher();
        }
        else
        {
            Console.WriteLine("Sexo inválido. Use apenas M ou F.");
            return;
        }

        double pesoIdeal = pessoa.GetPesoIdeal(altura);
        Console.WriteLine($"O peso ideal para a altura {altura}m é: {pesoIdeal:F2} kg");
    }
}