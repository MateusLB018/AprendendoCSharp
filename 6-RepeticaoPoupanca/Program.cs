using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_RepeticaoPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorinvestido = 1000;
            double fatorrendimento = 1.0036;


            /* while (cont <= 12)
             {
                 valorinvestido = valorinvestido + valorinvestido * 0.0036;
                 Console.WriteLine("No mês " + cont + " o valor investido será de : " + valorinvestido);
                 cont += 1; ou cont++;
             }*/
            /*for (cont=1; cont<=12; cont++)
            {
                valorinvestido *= 1.0036;
                Console.WriteLine("No mês " + cont + " o valor investido será de : " + valorinvestido);
            }*/

            for (int contAno=1; contAno <= 5; contAno++)
            {
                for(int contMes=1; contMes <= 12; contMes++)
                {
                    valorinvestido *= fatorrendimento;
                }
                fatorrendimento += 0.0010;
            }

            Console.WriteLine("Ao término de investimento você terá: " +valorinvestido);
            Console.WriteLine("Aperte enter para finalizar ");
            Console.ReadLine();
        }
    }
}
