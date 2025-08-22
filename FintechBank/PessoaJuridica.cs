using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FintechBank
{
    public class PessoaJuridica(string nome, string endereco, string telefone) : Pessoa(nome, endereco, telefone)
    {
        public long cnpj { get; set; }
        public string razaoSocial { get; set; }
        public string nomeRepresentante {  get; set; }

        public override void exibirDados()
        {
            Console.WriteLine($"name: {Nome}; adress: {Endereco}; tel: {Telefone}");
        }
    }
}
