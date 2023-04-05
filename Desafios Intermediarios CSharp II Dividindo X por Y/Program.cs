using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Intermediarios_CSharp_II_Dividindo_X_por_Y
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

class Desafio
        {
            static void Main()
            {
                int limit;
                if (Int32.TryParse(Console.ReadLine(), out limit))
                {
                    for (int i = 0; i < limit; i++)
                    {
                        string[] line = Console.ReadLine().Split(" ");
                        double X = double.Parse(line[0]);
                        double Y = double.Parse(line[1]);
                        if (Y == 0)
                        {
                            Console.WriteLine("divisao impossivel");
                        }
                        else
                        {
                            double resultado = X / Y;
                            Console.WriteLine(resultado.ToString("F1"));
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                }
            }
        }
    }
    }
}
