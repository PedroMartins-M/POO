using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ColecaoDicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> alunos = new Dictionary<int, string>();

            // Exemplo de entrada de dados
            var entradas = new (int RA, string Nome)[]
            {
            (101, "Ana"),
            (102, "Jo"),
            (103, "Carlos"),
            (104, "Lu")
            };

            foreach (var entrada in entradas)
            {
                if (entrada.Nome.Length >= 3) // validação do nome
                {
                    alunos.Add(entrada.RA, entrada.Nome);
                }
                else
                {
                    Console.WriteLine($"Nome inválido para RA {entrada.RA}: '{entrada.Nome}'");
                }
            }

            // Exibindo os dados
            Console.WriteLine("\nAlunos cadastrados:");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"RA: {aluno.Key}, Nome: {aluno.Value}");
            }
    }

