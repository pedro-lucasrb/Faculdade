using System;

namespace Triângulo
{
    class Program
    {
        static void Main(string[] args)
        {

            double base1, alt1, lado, area, perimetro;

            Console.WriteLine("Digite a Base:");
            base1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a Altura");
            alt1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite o valor do terceiro lado para o cálculo do perímetro");
            lado = Convert.ToInt32(Console.ReadLine());
            
            area = (base1 * alt1) / 2;

            perimetro = (lado + base1 + alt1);

            Console.WriteLine("A área do triângulo é: {1} e seu perímetro é {0}", perimetro, area);
            

            /*double alt, lado1, lado2, lado3, perimetro, area;
            Console.WriteLine("Programa para calcular a area e o perimetro do Triângulo:");

            Console.WriteLine("Digite o valor do primeiro lado:");
            lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do segundo lado");
            lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do terceiro lado");
            lado3 = Convert.ToInt32(Console.ReadLine());

            perimetro = (lado1 + lado2 + lado3);

            Console.WriteLine("O perimetro do triangulo é: {0} ", perimetro);*/

            






        }
    }
}
