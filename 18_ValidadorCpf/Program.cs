using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _18_ValidadorCpf
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Console.Write("Digite o CPF: ");
            //string cpf =  Console.ReadLine();
            //CPF objCPF = new CPF( cpf );
            IDocumento documento = new Cpf(Console.ReadLine());

            if (documento.Validar())
                Console.WriteLine("Documento válido!");
            else
                Console.WriteLine("Documento inválido!");

            Console.Write("Digite o CNPJ: ");
            documento = new Cnpj(Console.ReadLine());

            if (documento.Validar())
                Console.WriteLine("Documento válido!");
            else
                Console.WriteLine("Documento inválido!");
        }
    }
}
