using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int Multiplicador = 1; Multiplicador <= 10; Multiplicador++)
            {
                for(int contador = 1; contador <= 10; contador++)
                {
                    Console.Write("A multiplicação de " + Multiplicador + " por " + contador + " dará : " + Multiplicador*contador);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine("Digite enter para finalizar : ");
            Console.ReadLine();
        }
    }
}
