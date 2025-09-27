using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_colecaoPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Stack<int> numeros = new Stack<int>();

            numeros.Push(10);
            numeros.Push(20);
            numeros.Push(30);
            numeros.Push(40);
            numeros.Push(50);
            numeros.Push(60);
            numeros.Push(70);
            numeros.Push(80);
            numeros.Push(90);
            numeros.Push(100);

            Console.WriteLine("Ultimo número inserido: " + numeros.Peek());

        }
    }
}
