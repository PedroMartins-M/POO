using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Propriedades
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            Conta conta = new Conta("346-45");

            conta.setNome ("Pedro Martins de Moraes");

            //Não é possivel atrbuir o valor em atributo privado
            //conta.Numero = "19766";

            //conta.saldo = -1000.00m;
            conta.Depositar(-1000.00m);

            //Com uso utilizando o método acessador
            conta.setSaldo(1000.00m);

            //Console.WriteLine($"Saldo Atual: {conta.getSaldo():c2}");
            conta.ImprimirSaldo();

            while (true)
            {
                Console.WriteLine("Informe a Operação: [D}=Depositar, [S]=Sacar ou [E]-Sair");
                string operacao = Console.ReadLine();

                if (operacao.ToUpper() == "D")
                {

                    Console.WriteLine("Informe o Valor para depósito: ");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "S")
                {

                    Console.WriteLine("Informe o Valor para Saque: ");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "E")
                {
                    Console.WriteLine($"Conta: {conta.getNumero()} Nome: {conta.getNome()} Saldo: {conta.getSaldo()}");
                    break;
                }
                else
                {
                    Console.WriteLine("Informe apenas as letras [D] para Depositar, [S] para Sacar ou [E] para Sair");
                }
            }
        }
    }

    public class Conta
    {
        private string Numero;
        
        private string nome;

        //public decimal Saldo;
        //Transformar a conta Saldo privado
        private decimal saldo;

        //Metodos acessadores
        public decimal getSaldo()
        {
            return saldo;
        }

        public void setSaldo(decimal saldo)
        {
            this.Depositar( saldo );
        }

            public string getNumero()
            {
                return Numero;
            }

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        
        public void Depositar(decimal valor)
        {
            if (valor > 0)
                saldo += valor;
            else
                Console.WriteLine("Valor de depósito incorreto, deve ser maior que zero!");
        }

        public void Sacar(decimal valor)
        {
            saldo -= valor;
        }

        public void ImprimirSaldo()
        {
            Console.WriteLine($"O saldo da conta: {saldo}");
        }

        public Conta(string numero)
        {
            this.Numero = numero;
        }
    }
}
