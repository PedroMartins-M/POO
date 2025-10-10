using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_CriandoExcecaoPersonalizada
{
    internal class NotaInvalidaException : Exception
    {
                public NotaInvalidaException()
                    : base("Erro: valor de nota inválido! A nota deve estar entre 0 e 10.")
                {
                }
            }
        }
