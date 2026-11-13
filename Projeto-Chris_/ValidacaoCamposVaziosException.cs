using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Chris_
{
    internal class ValidacaoCamposVaziosException: System.Exception
    {
        internal ValidacaoCamposVaziosException(string message) : base(message) { }
    }
}
