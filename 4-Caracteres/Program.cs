using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            char primeiraletra = 'a';
            Console.WriteLine(primeiraletra);

            primeiraletra = (char)65;
            Console.WriteLine(primeiraletra);

            primeiraletra = (char)(primeiraletra + 1);
            Console.WriteLine(primeiraletra);

            string frase = "Alura cursos online ";
            Console.WriteLine(frase);
            //o @ faz considerar tudo depois da " como string
            string cursos =
@"-.NET
-Java
-Python";
            Console.WriteLine(cursos);
            Console.WriteLine("Finalizando programa, digite enter....");
            Console.ReadLine();
        }
    }
}
