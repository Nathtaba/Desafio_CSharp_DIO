using System;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d,avg1, avg2;
            string[] values = Console.ReadLine().Split(' ');
            a = double.Parse(values[0]);
            b = double.Parse(values[1]);
            c = double.Parse(values[2]);
            d = double.Parse(values[3]);
            avg1 = ((a*2) + (b*3) + (c*4) + d) / 10;
            Console.WriteLine("Media: " +avg1.ToString("0.00"));
            if ( avg1 >= 7.0 )
            {
                Console.WriteLine("Aluno aprovado.");
            }
            if ( avg1 < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            if (avg1 >= 5.0 && avg1 <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                
                double e = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame: {0}", e);
                
                avg2 = (avg1 + e) / 2;
                if (avg2 >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                if (avg2 <= 4.9)
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: {0}", avg2.ToString("0.0"));
            }

            
        }
    }
}