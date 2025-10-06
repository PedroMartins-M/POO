using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _18_ValidadorCpf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine();

            if (cpf.Length != 11)
            {
                Console.WriteLine("CPF deve conter 11 digitos");
                return;
            }

            // 3- Validas CPFs com todos os números iguais
            /* if( cpf == "11111111111" || cpf == "22222222222" || cpf == "33333333333" ||
                 cpf == "44444444444" || cpf == "55555555555" || cpf == "66666666666" ||
                 cpf == "77777777777" || cpf == "88888888888" || cpf == "99999999999"                 
             )*/
            if (cpf.Distinct().Count() == 1)
            {
                Console.WriteLine("CPF inválido! Números repetidos não são permitidos");
                return;
            }

            int digX = CalculaDV(cpf, 9, 10);

            int digY = CalculaDV(cpf, 10, 11);

            //6 - Comparar os dígitos
            if (
                int.Parse(cpf[9].ToString()) == digX &&
                int.Parse(cpf[10].ToString()) == digY
               )
            {
                Console.WriteLine("CPF VÁLIDO!");
            }
            else
            {
                Console.WriteLine("CPF INVÁLIDO!");
            }
        }

    }
    }
}
