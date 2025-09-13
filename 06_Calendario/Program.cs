using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using _06_Calendario.Properties;

namespace _06_Calendario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o ano: ");
            int ano = int.Parse(Console.ReadLine());

            Calendario calendario;
            for (int mes = 1; mes <= 12; mes++)
            {
                calendario = new Calendario(ano, mes);
                calendario.ImprimirCalendario();

                Console.WriteLine("\n\n");
            }

            Console.ReadKey();


        }

        private static void gerarCalendario(int ano, int mes, out DateTime primeiroDiaMes, out int[,] calendario)
        {

            int diasDoMes = DateTime.DaysInMonth(ano, mes);


            primeiroDiaMes = new DateTime(ano, mes, 1);
            int diaSemanaInicio = (int)primeiroDiaMes.DayOfWeek;


            calendario = new int[6, 7];
            int dia = 1;


            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (semana == 0 && diaSemana < diaSemanaInicio)
                    {
                        calendario[semana, diaSemana] = 0;
                    }
                    else if (dia <= diasDoMes)
                    {
                        calendario[semana, diaSemana] = dia;
                        dia++;
                    }
                }
            }
        }

    }
}    
 
