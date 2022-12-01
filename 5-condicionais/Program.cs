using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 16;
            int numeroPessoas = 2;

            if (idade >= 18)
            {
                Console.WriteLine("Possui maior idade pode entrar ");
            }
            else
            {
                if (numeroPessoas >= 2)
                {
                    Console.WriteLine("está acompanhado, então pode entrar ");
                }
                else
                {
                    Console.WriteLine("não pode entrar sinto muito ");
                }
            }
            //ou para poupar linhas de código poderia ser feito o seguinte:

            //bool acompanhado=idade>=18|| numeroPessoas; 

            //if(acompanhado==true)

            bool acompanhado = true;
            string mensagem;
            if (acompanhado == true)
            {
                mensagem = "Está acompanhado";
            }
            else
            {
                mensagem = "Não está acompanhado";
            }
            if(idade>=18 || acompanhado==true)   //&&= and ||= ou ==igual 
            {
                Console.WriteLine("Pode entrar"); //não tem como identificar qual permitiu teoricamente
                Console.WriteLine(mensagem);
            }
            else
            {
                Console.WriteLine("Não pode entrar ");
                Console.WriteLine(mensagem);
            }
            Console.WriteLine("Enter para finalizar : ");
            Console.ReadLine();
        }
    }
}
