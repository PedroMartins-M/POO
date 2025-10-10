using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_CriandoExcecaoPersonalizada
{

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Write("Digite a nota do aluno (0 a 10): ");
                try
                {
                    double nota = double.Parse(Console.ReadLine());

                    if (nota < 0 || nota > 10)
                    {
                        throw new NotaInvalidaException();
                    }

                    if (nota >= 6)
                    {
                        Console.WriteLine("Aluno aprovado!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Aluno reprovado!");                       
                    }
                }
                catch (NotaInvalidaException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: valor digitado não é numérico!");
                }

                finally
                {

                    Console.WriteLine("\nPressione qualquer tecla para sair...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
