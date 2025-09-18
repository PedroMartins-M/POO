using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _08_Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Aluno aluno = new Aluno(nome);

            Console.WriteLine("Digite sua Idade: ");
            aluno.Idade = int.Parse (Console.ReadLine());

            Console.WriteLine("Insira sua 1ºNota: ");
            aluno.Nota1 = double.Parse (Console.ReadLine());

            Console.WriteLine("Informe sua 2ºNota: ");
            aluno.Nota2 = double.Parse (Console.ReadLine());

            Console.WriteLine($"Nome: {aluno.Nome}");
            Console.WriteLine($"Idade: {aluno.Idade}");
            Console.WriteLine($"1ºNota: {aluno.Nota1}");
            Console.WriteLine($"2ºNota: {aluno.Nota2}");
            Console.WriteLine($"Média: {aluno.Media}");
            Console.WriteLine($"Situação: {aluno.Situacao}");
        }
    }

    public class  Aluno
    {
        private string nome;
        private int idade;
        private double nota1, nota2;
        private double media;
        public string Situacao
         {
            get { { return (Media >= 6) ? "Aprovado" : "Reprovado"; } }
        }

        public Aluno(string nome)
        {
            this.nome = nome;
        }
        public string Nome
        {
            get {  return nome; }
        }

        public int Idade
        {
            get { return idade; }         
            set
            {
                if (value > 0)
                    idade = value;
                else
                    Console.WriteLine("Idade Inválida");
            }
        }

        public double Nota1 { get; set; }

        public double Nota2 { get; set; }
       

        public double Media
        {
            get {
                return (Nota1 + Nota2) / 2;
            }
        }
       
    }
}
