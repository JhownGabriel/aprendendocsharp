using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float HT, VH, PD, SB, TD, SL; /* HT = Horas trabalhadas
                                           * VH = Valor da hora
                                             PD = Valor do percentual de desconto
                                             SL = Salario liquido
                                             SB = Salario Bruto
                                             TD = Total de desconto */

            Console.Write("Horas trabalhadas ...............: ");
            HT = float.Parse(Console.ReadLine()); /* atribui o valor a HT */
            Console.Write("valor da hora ................... ");
            VH = float.Parse(Console.ReadLine()); /* atribui o valor a VH */
            Console.Write("Valor do percentual de desconto .: ");
            PD = float.Parse(Console.ReadLine()); /* atribui o valor a PD */

            SB = HT * VH; /* Horas trabalhadas + valor da hora = Salario Bruto */
            TD = (PD / 100) * SB; /* (Valor percentual de desconto / 100) * Salario bruto = Total de desconto */
            SL = SB - TD; /* Salario Bruto - Total de desconto = Salario liquido */

            Console.WriteLine();
            Console.Write("Salario liquido ................: ");
            Console.WriteLine(SL.ToString("##,##0.00")); /* cria uma mascara do SL pra string */

            Console.WriteLine();
            Console.Write("Tecla <enter> para encerrar... ");
            Console.ReadLine();
        }
    }
}
