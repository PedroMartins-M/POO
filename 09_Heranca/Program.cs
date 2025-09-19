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

            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Geraldo";
            pessoaFisica.CPF = "222-444-333-45";
            pessoaFisica.Telefone = "(14) 14565-5464";
            pessoaFisica.Imprimir();

            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Senac Marilia";
            pessoaJuridica.CNPJ = "99-444-555-76";
            pessoaJuridica.Telefone = "(113) 23543-1245";
            pessoaJuridica.Imprimir();
        }
    }
}
