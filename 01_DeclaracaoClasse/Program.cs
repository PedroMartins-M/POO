using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
            obj5.ImprimeArea();

            Conta contaPedro = new Conta();
            contaPedro.Banco = 256;
            contaPedro.Agencia = "034-4";
            contaPedro.Numero = "99520-4";
            contaPedro.Saldo = 5;

            contaPedro.Sacar(34);
            Console.WriteLine($"Saldo Atual: {contaPedro.ConsultaSaldo()}");

            contaPedro.Depositar(1245);
            Console.WriteLine($"Saldo Atual: {contaPedro.ConsultaSaldo()}");

            //Aluno
            Aluno aluno1 = new Aluno();
            aluno1.Codigo = 1;
            aluno1.Nome = "Pedro";
            //inicializando o vetor com 4 posicoes

            aluno1.LancarNota(0, 9.6);
            aluno1.LancarNota(1, 8.0);
            aluno1.LancarNota(2, 9.5);
            aluno1.LancarNota(3, 10.0);

            Console.WriteLine($"Aluno: {aluno1.Nome}, Media: {aluno1.CalcularMedia():N1} , Situação: {aluno1.Mencao()}");
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

    public class Conta
    {
        public int Banco;
        public string Agencia;
        public string Numero;
        public double Saldo;
        public double Limite;

            public void Depositar (double Valor)
        {
            Valor += Saldo;
        }

        public void Sacar (double Valor)
        {
            Valor -= Saldo;
        }

        public double ConsultaSaldo ()
        {
        return Saldo;
        }
    }
    public class Aluno
    {
        public int Codigo;
        public string Nome;
        public double[] Notas = new double[4];

        public void LancarNota(int indice, double nota) //int trimestre, double nota, Professor fez assim
        {
            Notas[indice] = nota;  //Notas[trimestre - 1] = nota;
        }
        public double CalcularMedia()
        {
            double soma = 0; //local que vai acumular a soma das notas.
            for (int i = 0; i < Notas.Length; i++) //percorrer o vetor
            {
                soma += Notas[i]; //acumular as notas
            }
            return soma / Notas.Length; //retornar a media; Notas.Length = quantidade de notas
        }

        //public double CalcularMedia()    OBS: Outra forma de fazer a media, Professor fez assim
        //{
        //    double media = 0;
        //    foreach (double nota in Notas)
        //    {
        //        media += nota;
        //    }
        //}

        public string Mencao()
        {
            if (CalcularMedia() >= 5)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }

    }
}
