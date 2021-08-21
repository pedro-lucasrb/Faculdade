using System;

namespace Antes_e_Depois
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, total, resultado;
        
            Console.WriteLine("Sucessor e Antecessor do seu número:");

            Console.WriteLine("Digite o Seu número");
            num1 = Convert.ToInt32(Console.ReadLine());

            resultado = (num1 + 1);
            total = (num1 - 1);
           
            Console.WriteLine("O antecessor do seu número é: {1} e o Sucessor é: {0}", resultado, total);
        }
    }
}
