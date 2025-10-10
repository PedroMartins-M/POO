using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _21_ConversaoNumeroComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Numero;
            Dobro calculadora = new Dobro();

            while (true)
            {


                Console.WriteLine("Digite um número inteiro: ");
                try
                {
                    Numero = int.Parse(Console.ReadLine());

                    int resultado = calculadora.Dobrar(Numero);
                    Console.WriteLine($"O dobro de {Numero} é {resultado}");
                    break;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Valor inválido! Digite apenas números inteiros.");
                    Console.ReadKey();
                }
                finally
                {
                    Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        public class Dobro
        {
            public int Dobrar(int numero)
            {
                return numero * 2;
            }
        }
    }
}
