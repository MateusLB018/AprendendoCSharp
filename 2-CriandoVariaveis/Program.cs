using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("executando programa 2 testando ");

            int idade;
            idade = 42;
            Console.WriteLine(idade);

            double salario;
            salario = 1200.0/7; //senao colocar o .0 o valor nao sera impresso em double e sim em int
            Console.WriteLine("meu salário é: " + salario);

            Console.WriteLine("Finalizado aperte enter ");
            Console.ReadLine();
        }
    }
}
