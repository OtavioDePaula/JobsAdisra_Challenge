using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsAdisra_Challenge.Exercicios.Exercicio_1
{
    internal class Fibonnaci
    {
        public string calculoFibonnaci() 
        {
            Console.WriteLine("Digite a posição do número que deseja na sequência Fibonnaci: ");
            int position = Convert.ToInt16(Console.ReadLine());

            if (position <= 1)
            {
                return "O valor de n é: " + position;
            }
            else
            {
                int[] fibonacciSequence = new int[position + 1];
                fibonacciSequence[1] = 1;

                for (int i = 2; i <= position; i++)
                {
                    fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
                }

                return $"Na posição {position} está o número {fibonacciSequence[position]}";
            }
        }
    }
}
