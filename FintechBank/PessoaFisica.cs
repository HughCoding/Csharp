using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FintechBank
{
    public class PessoaFisica(string nome, string endereco, string telefone) : Pessoa(nome, endereco, telefone)
    {
        
        public long Cpf { get; set; }
        public int EstadoCivil { get; set; }

        public override void exibirDados()
        {
            Console.WriteLine($"name: {Nome}; adress: {Endereco}; tel: {Telefone}");
        }
    }
}
