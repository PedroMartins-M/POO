using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DeclaracaoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado obj1 = new Quadrado();
            obj1.Lado = 5;
            obj1.ImprimeArea();

            obj1.Lado = 15;
            obj1.ImprimeArea();

            Quadrado obj2 = new Quadrado();
            obj2.Lado = 25;
            obj2.ImprimeArea();

            Retangulo obj3 = new Retangulo();
            obj3.Base = 20;
            obj3.Altura = 20;
            obj3.ImprimeArea();

            Circulo obj4 = new Circulo();
            obj4.Raio = 5;
            obj4.ImprimiArea();

            Triangulo obj5 = new Triangulo();
            obj5.Altura = 25.5;
            obj5.Base = 12.75;
            obj5.ImprimeArea();
        }
    }
    public class Quadrado
    {
        public int Lado;

        public int CalculaArea()
        {
            int area = Lado * Lado;
            return area;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($" Quadrado com área de {Lado} possui uma área de {CalculaArea()}");
        }
    }
    public class Retangulo
    {
        public int Altura;
        public int Base;

        public int CalculaArea()
        {
            int area = Altura * Base;
            return area;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($" Retangulo com Altura de {Altura} e Base de {Base} possui uma altura de {CalculaArea()}");
        }
    }

    public class Circulo
    {
        public int Raio;

        public double CalculoArea()
        {
            return Math.PI * (Raio * Raio);
        }

        public void ImprimiArea()
        {
            Console.WriteLine($" Circulo com raio de {Raio} possui Area de {CalculoArea()}");
        }
    }

    public class Triangulo
    {
        public double Base, Altura;
    
     public double CalculaArea()
        {
            return Base * Altura / 2;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Triângulo com base de {Base:N2}, altura de {Altura:N2} possui uma área de {CalculaArea():N2}");

        }
    }
}
