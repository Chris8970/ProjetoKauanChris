using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Chris_
{
    internal class Globais
    {
        internal struct Utilizador
        {
            public string email;
            public string palavraPasse;
            
        }
        public static Utilizador[] listaUtilizadores = new Utilizador[50];
        public static int posicaovazia = 0;
        public static string emails = "";
        public static string passwords = "";
       
    }
}
