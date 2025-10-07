using System;
using System.Linq;
using System.Text.RegularExpressions;
using _20_ValidaCPFComExcecao;

namespace _20_ValidaCPFComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IDocumento documento;
            while (true)
            {
                Console.WriteLine("Informe o CPF");
                try
                {
                    string cpf = Console.ReadLine();

                    documento = new CPF(Console.ReadLine());
                    break;
                }

                catch (CPFMesmoNumeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (CPFQtdeDigitosException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"CPF invalido: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                }

            }

            if (documento.Validar())
            {
                Console.WriteLine("CPF Válido!");
            }
            else
            {
                Console.WriteLine("CPF Inválido!");
            }

            /*
            Console.WriteLine("Informe o CPF");
            CPF cpf = new CPF(Console.ReadLine());
                             OU
            IDocumento documento = new CPF(Console.ReadLine());

            if(cpf.Validar())
                Console.WriteLine("CPF válido")
            else
                Console.WriteLine("CPF inválido")

             */
        }

    }

}



