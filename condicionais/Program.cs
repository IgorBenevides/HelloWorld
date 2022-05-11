using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constante
{
    class condicional
    {
        static void Main(string[] args)
        {
            // ( = atribuiçao) (== igual) (!= diferente) (>= maior ou igual)
            // ( <= menor ou igual) true or false.
            // &&(e ou and)  e ||(Ou/or)
            // CONDI1 && CONDI2 => VERDADE
            // SERMULHER && IDADE >= 25 -> Entrada na festa gratis!
            // TRUE && TRUE -> true

            int a = 10;
            int b = 20;
            int c = 2;

            if (a != b && a > c ) // SE
            {
                Console.WriteLine("é verdade!");

            }
            else if (a == a) //SE NAO SE
            {
                Console.WriteLine("else if");

            }
            else //SE NAO
            {
                Console.WriteLine("é mentira!");
            }

            Console.ReadLine();
        }
    }
}