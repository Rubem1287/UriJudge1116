using System;
using System.Globalization;
namespace Uri1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double m;
            m = 0;


            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                double a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vetor[1], CultureInfo.InvariantCulture);


                m = (double)a / b;

                if (m == double.PositiveInfinity || m == double.NegativeInfinity)
                {
                    Console.WriteLine("Impossível Calcular");
                }
                else
                {
                    Console.WriteLine(m.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
