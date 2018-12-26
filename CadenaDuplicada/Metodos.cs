using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaDuplicada
{
    public class Metodos
    {
        
        public static string DuplicateEncode(string word)
        {

            string Cadena = string.Empty;
            char[] Caracter;
            Caracter = word.ToCharArray();

            foreach (var item in Caracter)
            {
                int Cantidad = 0;
                for (int i = 0; i < Caracter.Length; i++)
                {
                    if (item == Caracter[i])
                    {
                        Cantidad = Cantidad + 1;
                    }
                }
                if (Cantidad > 1)
                {
                    Cadena = Cadena+")";
                     
                }
                else
                {
                    Cadena = Cadena + "(";
                    
                }
            }


            return Cadena;
        }
    }

}

