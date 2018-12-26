using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaDuplicada
{
    class Program
    {
        static void Main(string[] args)
        {

            string Cadena;
            Console.WriteLine("Escribre una palabra");
            Cadena = Console.ReadLine();
            Console.Write(Metodos.DuplicateEncode(Cadena));
            Console.ReadKey();
        }
    }
}
