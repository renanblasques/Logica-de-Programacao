using System.Net.Quic;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double oldSalary, newSalary, increaseRate, increase;

                oldSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (oldSalary <= 400.0)
                {
                    increaseRate = 1.15;
                }
                else if (oldSalary <= 800.0)
                {
                    increaseRate = 1.12;
                }
                else if (oldSalary <= 1200.0)
                {
                    increaseRate = 1.10;
                }
                else if (oldSalary <= 2000.0)
                {
                    increaseRate = 1.07;
                }
                else
                {
                    increaseRate = 1.04;
                }

                newSalary = oldSalary * increaseRate;
                increase = newSalary - oldSalary;

                Console.WriteLine("Novo salario: " +
                    newSalary.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " +
                    increase.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " +
                    Math.Round(((increaseRate - 1) * 100)) + "%");
            }


        }
    }
}
