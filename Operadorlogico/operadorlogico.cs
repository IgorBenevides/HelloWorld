using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class operadorlogico
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua idade");

            if (idade >= 0 && idade <= 12)
            {
                Console.WriteLine("Sim voce é uma criança");
            }
            else if (idade >= 13 && idade <= 18)
            {
                Console.WriteLine("Voce é adolescente");
            }
            else
            { 
                Console.WriteLine("Voce é adulto");
            }


            Console.WriteLine();
        }
    }
}
