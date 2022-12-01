using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;

        if (salario >= 1900.0 && salario<=2800.0)
        {
            Console.WriteLine("O imposto é de 7,5% ");
            Console.WriteLine("Deduzir o valor de R$ 142");
        }

        if (salario >= 2800.1 && salario<=3751.0)
        {
            Console.WriteLine("O imposto de renda é de 15% ");
            Console.WriteLine("Deduzir o valor de R$ 350");
        }

        if (salario >= 3751.1 && salario <= 4664.0)
        {
            Console.WriteLine("O imposto de renda é de 22.5%");
            Console.WriteLine("Deduzir o valor de R$ 636");
        }

        Console.WriteLine("Aperte enter para finalizar");
        Console.ReadLine();
    }
}