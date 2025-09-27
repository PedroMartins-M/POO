using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ColecaoFila
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
                    Console.WriteLine($"Digite o {i + 1}ºnome:");
                    nome = Console.ReadLine();

                    if (string.IsNullOrEmpty(nome) || nome.Length < 3)
                    {
                        Console.WriteLine("❌ Mome Invalido! Digite Novamente.");
                    }
                } while (string.IsNullOrEmpty(nome) || nome.Length <3);

                nomes.Add(nome);
            }
 
            Console.WriteLine("\n== Lista de Nomes Cadastrados ==");
            int posicao = 1;
            foreach (string nome in nomes)              
            {
                Console.WriteLine($"-{posicao}º - {nome}");
                posicao++;
            }

            Queue<string> fila = new Queue<string>();
            foreach (string nome in nomes)
            {
                fila.Enqueue(nome);
            }

            Console.WriteLine("\n== Em atendimento ==");
            int contador = 1;
            while (fila.Count > 0)
            {
                string atendido = fila.Dequeue();
                Console.WriteLine($"Senha {contador}: {atendido} foi atendido");
                contador++;
            }

        }
    }
}
