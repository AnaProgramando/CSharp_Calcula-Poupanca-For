using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto - Laço de Repetição FOR: \r\n");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                //O valor da variável será multiplicado por 1.0036 e será guardado novamente em valorInvestido.         
                valorInvestido *= 1.0036;
                //A forma acima é uma versão resumida de: valorInvestido = valorInvestido + valorInvestido * 0.0036;

                Console.WriteLine("Após " + contadorMes + " meses, você terá R$ " + valorInvestido + ".");
            }

            Console.ReadLine();
        }
    }
}
