using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Conversoes
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 1200.75;

            //int suporta ate 2 bilhoes (32bits)
            int salarioInt;
            salarioInt = (int)salario;

            long numerodeestrelas = 120000000000;//o long suporta Muito mais (64bits)
            short quantidadedeprodutos = 166; //o short suporta até 16000 (16bits)

            Console.WriteLine(salarioInt);

            float altura = 1.80f;
            //o float é menor do que o double e menos usual no c#, o ideal é usar double, mas se necessário float, colocar f depois do valor

            Console.WriteLine(numerodeestrelas);
            Console.WriteLine(quantidadedeprodutos);
            Console.WriteLine(altura);

            Console.WriteLine("Finalizar aperte enter... ");
            Console.ReadLine();
        }
    }
}
