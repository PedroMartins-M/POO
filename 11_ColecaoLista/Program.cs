using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ColecaoLista
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> nomes = new List<string>();
            Console.WriteLine("== Cadastro de Nomes ==");

            for (int i = 0; i < 5; i++)
            {
                string nome;
                do
                {
                    Console.Write($"Digite o {i + 1}º nome: ");
                    nome = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(nome) || nome.Length < 3)
                    {
                        Console.WriteLine("❌ Nome inválido! Digite novamente.");
                    }

                } while (string.IsNullOrWhiteSpace(nome) || nome.Length < 3);

                nomes.Add(nome);
            }

            Console.WriteLine("\n== Lista de Nomes Cadastrados ==");
            foreach (string nome in nomes)
            {
                Console.WriteLine($"- {nome}");
            }
        }
    }
}
    