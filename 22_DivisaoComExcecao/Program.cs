using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_DivisaoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Numero;
            int Divisor;
            Divisao Calculadora = new Divisao();

            while (true)
            {
                Console.WriteLine("Digite seu número: ");

                try
                {
                    Numero = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o divisor: ");
                    Divisor = int.Parse(Console.ReadLine());

                    double resultado = Calculadora.Dividir(Numero, Divisor);
                    Console.WriteLine($"{Numero} dividido por {Divisor} é {resultado}");
                    break;
                }

                catch (FormatException)
                {
                    Console.WriteLine("Valor inválido! Digite apenas números inteiros.");
                    Console.ReadKey();
                }

                catch (DivideByZeroException)
                {
                    Console.WriteLine("Erro: não é possível dividir por zero!");
                }

                finally
                {
                    Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }

    public class Divisao
    {
        public int Dividir(int numero, int divisor)
        {

            if (divisor == 0)
            throw new DivideByZeroException();

            return numero / divisor;
        }
    }
}
