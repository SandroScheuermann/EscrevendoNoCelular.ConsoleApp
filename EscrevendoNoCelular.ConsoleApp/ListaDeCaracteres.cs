using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoNoCelular.ConsoleApp
{
    class ListaDeCaracteres
    {
        private static List<char> espaco = new List<char> { ' ' };
        private static List<char> um = new List<char> {' '};
        private static List<char> dois = new List<char> { ' ', 'A', 'B', 'C' };
        private static List<char> tres = new List<char> { ' ', 'D', 'E', 'F' };
        private static List<char> quatro = new List<char> { ' ', 'G', 'H', 'I' };
        private static List<char> cinco = new List<char> { ' ', 'J', 'K', 'L' };
        private static List<char> seis = new List<char> { ' ', 'M', 'N', 'O' };
        private static List<char> sete = new List<char> { ' ', 'P', 'Q', 'R', 'S' };
        private static List<char> oito = new List<char> { ' ', 'T', 'U', 'V' };
        private static List<char> nove = new List<char> { ' ', 'W', 'X', 'Y', 'Z' };

        private static List<List<char>> listaCaracteres = new List<List<char>> { espaco, um, dois, tres, quatro, cinco, seis, sete, oito, nove };
        public List<List<char>> ListaCaracteres { get => listaCaracteres; }
    }
}
