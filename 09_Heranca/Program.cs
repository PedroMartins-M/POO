using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Não é possivel instanciar uma classe abstrata
            //Pessoa obj = new Pessoa
            Pessoa[] pessoas = new Pessoa[2];

            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoas[0] = pessoaFisica;
            pessoaFisica.Id = 1;
            pessoaFisica.Nome = "Geraldo";
            pessoaFisica.CPF = "222-444-333-45";
            pessoaFisica.Telefone = "(14) 14565-5464";
            pessoaFisica.Imprimir();

            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Id = 1;
            pessoaJuridica.Nome = "Senac Marilia";
            pessoaJuridica.CNPJ = "99-444-555-76";
            pessoaJuridica.Telefone = "(113) 23543-1245";
            pessoaJuridica.Imprimir();

            Console.WriteLine(pessoaFisica);
            Console.WriteLine(pessoaJuridica);

            if (pessoaFisica.Equals(pessoaJuridica))
                Console.WriteLine($"É a mesma pessoa");
            else
                Console.WriteLine($"Não é a mesma pessoa");

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}
