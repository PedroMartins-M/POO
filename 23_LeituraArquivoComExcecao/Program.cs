using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_LeituraArquivoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o caminho completo do arquivo (ex: C:\\temp\\arquivo.txt): ");
            string caminho = Console.ReadLine();

            try
            {
                // Tenta ler o conteúdo do arquivo
                string conteudo = File.ReadAllText(caminho);
                Console.WriteLine("\nConteúdo do arquivo:\n");
                Console.WriteLine(conteudo);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Arquivo não encontrado! Verifique o caminho e tente novamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
            }
        }
    }  
}
