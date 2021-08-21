using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunosMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            double aluno1, aluno2, aluno3, aluno4, aluno5;
            double media, meio;

            Console.WriteLine("Digite a nota do Primeiro aluno");
            aluno1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota do Segundo aluno");
            aluno2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota do Terceiro aluno");
            aluno3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota do Quarto aluno");
            aluno4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota do Quinto aluno");
            aluno5 = Convert.ToDouble(Console.ReadLine());

            media = aluno1 + aluno2 + aluno3 + aluno4 + aluno5 / (5);
            meio = media;

            Console.Write("A media da nota dos alunos é:");
            Console.Write(meio);
            Console.ReadKey();
        }
    }
}


            