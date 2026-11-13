using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Chris_
{
    internal class ValidacaoEmailException: System .Exception
    {
        internal ValidacaoEmailException(string message) : base(message) { } //Escrevi errado Validação... Não sei como mudar o nome sem dar erro.
    }
}
