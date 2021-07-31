using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 2) dado a seguinte expressão:
 * x + y + d + 5 * 77 + 8 -10 *( 8/3)
 * Qual é o resultado da operação feita em algoritmo
 */

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {

            double x, y, d, resultado, parcial;
            Console.WriteLine(" Digite o valor de x : ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Digite o valor de y : ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Digite o valor de d : ");
            d = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine("Resultado = " + (x + y + d + (5 * 77) + 8 - (10 *(double)8/(double)3)));
            Console.ReadKey();
        }
    }
}
