using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado(5);
            quadrado.ImprimirArea();

            Retangulo retangulo = new Retangulo(5, 5);
            retangulo.ImprimirArea();

            Circulo circulo = new Circulo(7.5);
            circulo.ImprimeArea();

            Triangulo triangulo = new Triangulo(12.75, 25.5);
            triangulo.ImprimeArea();
        }
    }

    public class Quadrado
    {
        //Modificar de acesso Private
        //pode ser acessado apenas dentro da classe
        private int Lado;

        //Overload (Sobrecarga) de Construtor
        //Declarar mais de um construtor com a lista de argumentos diferentes
        // Construtor não tem retorno
        public Quadrado() : this(5) // Quando não for passado nenhum valor, o lado será 5
        {
            //this.Lado = 5;  

        }

        //Construtor serve para instanciar o objeto e inicializar os atributos
        public Quadrado(int Lado)
        {
            //Acessando o atributo Lado da classe
            this.Lado = Lado;
        }


        //O construtor serve para instanciar o objeto e Inicializae os atributos
        public int CalculaArea()
        {
            return Lado * Lado;
        }

        public void ImprimirArea()
        {
            Console.WriteLine($"Quadrado com {Lado} lados possui uma área de {CalculaArea()}");
        }
    }

    public class Retangulo
    {
        private int Largura, Altura;

        public Retangulo(int largura, int altura)
        {
            this.Largura = largura;
            this.Altura = altura;
        }

        public int CalculaArea()
        {
            return Largura * Altura;
        }

        public void ImprimirArea()
        {
            Console.WriteLine($"Retangulo com Largura de {Largura}, altura de {Altura} possui uma Àrea de {CalculaArea()}");
        }
    }

    public class Circulo
    {
        private double Raio;
        private const double Pi = 3.14;
        public Circulo(double Raio)
        {
            this.Raio = Raio;
        }
        private double CalcularArea()
        {
            return Pi * (Raio * Raio);
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Círculo com raio de {Raio} possui uma àrea de   {CalcularArea()}");
        }
    }
    public class Triangulo
    {
        private double Base, Altura;
        public Triangulo(double Base, double Altura)
        {
            this.Base = Base; this.Altura = Altura;
        }
        private double CalcularArea()
        {
            return (Base * Altura) / 2;
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Triângulo com base de {Base} e altura de {Altura} possui uma àrea de   {CalcularArea()}");

        }
    }
}
