using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ColecaoHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numeros = new HashSet<int>();
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(30);
            numeros.Add(40);
            numeros.Add(50);
            numeros.Add(50);
            numeros.Add(60);
            numeros.Add(70);
            numeros.Add(80);
            numeros.Add(90);
            numeros.Add(100);

            Console.WriteLine("Números no HashSet (sem duplicatas):");
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }

        }
    }
}
