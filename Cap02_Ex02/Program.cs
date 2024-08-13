using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, R; /* variaveis para fazer uma conta de somar */

            Console.Write("Entre o 1o. valor: "); /* primeiro valor */
            A = int.Parse(Console.ReadLine()); /* atribui a o valor */

            Console.Write("Entre o 2o. valor: "); /* segundo valor */
            B = int.Parse(Console.ReadLine()); /* atribui a o valor */

            R = A + B; /* A + B é somado e o resultado atribuido a R */

            Console.WriteLine();
            Console.WriteLine("Resultado = " + R); /* mostra a palavra resultado + o valor somado */

            Console.WriteLine();
            Console.Write("tecla <Enter> para continuar... ");
            Console.ReadLine();
        }
    }
}
