using System;

namespace Desconto
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, desconto, resultado;
            Console.WriteLine("Calculadora de Descontos");

            Console.WriteLine("Digite o Valor do produto");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o desconto");
            desconto = Convert.ToInt32(Console.ReadLine());

            resultado = (valor1 - desconto) / 100;

            Console.WriteLine("Valor Final: {0}", resultado);
            
        }
    }
}
