namespace FintechBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PessoaFisica pf1 = new PessoaFisica("Pedro","Rua Joao Mendes","99123414");
            PessoaJuridica pj1 = new PessoaJuridica("Ana", "Avenida Sao Paulo", "991242215");


            pf1.exibirDados();
            pj1.exibirDados();


        }
    }
}
