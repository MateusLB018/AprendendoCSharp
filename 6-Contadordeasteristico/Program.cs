using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Contadordeasteristico
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int contLinha=0; contLinha<=10;contLinha++)
            {
                /*for(int contColuna = 0; contColuna <= 10; contColuna++)
                {
                    Console.Write("*");//não pula linha
                    if (contColuna==contLinha)
                    {
                        break;
                    }

                }*/
                for(int contColuna = 0; contColuna <= contLinha; contColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Digite Enter para finalizar ");
            Console.ReadLine();
        }
    }
}
