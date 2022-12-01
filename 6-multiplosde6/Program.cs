using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_multiplosde6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* for (int cont=0;cont<=100;cont++)
             {
                 if (cont%3==0)
                 {
                     Console.WriteLine("Multiplos de 3 : " + cont);
                 }
             }*/
            for (int cont = 0; cont <= 100; cont += 3)
            {
                Console.WriteLine(cont);
            }
            
            Console.WriteLine("Digite enter para finalizar : ");
            Console.ReadLine();
        }
    }
}
