using System;
using System.Threading;

namespace Conversor_de_temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double cels1, conversao; 
            Thread.Sleep(10);
            Console.WriteLine("Conversor de Temperatura; Celsius => Fahrenheit.");           
            Console.WriteLine("Digite a Temperatura em Celsius");
            cels1 = Convert.ToInt32(Console.ReadLine());

            conversao = (9 * cels1 + 160) / 5; 

            Console.WriteLine("A temperatura em Fahrenheit é:{0}", conversao);
        }
    }
}
