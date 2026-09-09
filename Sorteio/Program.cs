using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Escolha_Do_Oponente=new Random();
            int elemento = Escolha_Do_Oponente.Next(0, 3);

            if (elemento == 0)
            {
                Console.WriteLine("O elemento sorteado foi Fogo!");
            }
            else if (elemento == 1)
            {
                Console.WriteLine("O elemento sorteado foi Água!");
            }
            else if (elemento == 2)
            {
                Console.WriteLine("O elemento sorteado foi Planta!");
            }
        }
    }
}
