using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoNoCelular.ConsoleApp
{
    public class TransformaQwerty
    {
        ListaDeCaracteres lista = new ListaDeCaracteres();
        string qwerty;

        public string RetornaQwerty(string fraseRecebida)
        {
            for (int i = 0; i < fraseRecebida.Length; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (lista.ListaCaracteres[j].Contains(fraseRecebida[i]))
                    {
                        if (i > 0 && qwerty[qwerty.Length - 1].ToString().Equals(j.ToString()))
                            qwerty += "_";
                        for (int k = 0; k < lista.ListaCaracteres[j].IndexOf(fraseRecebida[i]); k++)
                        {
                            qwerty += j.ToString();
                            continue;
                        }
                        if (j == 0)
                            qwerty += j.ToString();
                    }
                }
            }
            return qwerty;
        }
    }
}
