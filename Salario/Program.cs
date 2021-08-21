using System;

namespace Salário
{
    class Program
    {
        static void Main(string[] args)
        {
            double func, total;
            const int sal = 1100;
            Console.WriteLine("Contador Salarial:");

            Console.WriteLine("Digite o seu salário");
            func = Convert.ToInt32(Console.ReadLine());
            //Rever esse caso com o Camillo, pois ele está arredondando
            total = Convert.ToInt32((func / sal)); 

            Console.WriteLine("Você ganha aproximadamente: {0} salários", total);
                        
        }
    }
}
