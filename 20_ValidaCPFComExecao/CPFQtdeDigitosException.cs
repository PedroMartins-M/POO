using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ValidaCPFComExcecao
{
    public class CPFQtdeDigitosException : Exception
    {
        public CPFQtdeDigitosException() :base ("CPF deve conter 11 digitos!") { }
    }
}
