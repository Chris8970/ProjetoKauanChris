using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Chris_
{
    internal class Globais
    {
        internal struct Verificar
        {
            public bool verificar;
        }
        public static bool ver;
        internal struct Utilizador
        {
            public string email;
            public string palavraPasse;

        }
        public static Utilizador[] listaUtilizadores = new Utilizador[50];
        public static int posicaovazia = 0;
        public static string emails = "";
        public static string passwords = "";

        internal struct Alterações
        {
            public string apelido;
            public string emailAlt;
            public string palavraPasseAlt;
        }
        public static Alterações[] listaApelidos = new Alterações[50];
        public static int posicoesvazia = 0;
        public static string apelidoss = "";
        public static string novoemail = "";
        public static string novapassword = "";

    }
}
