using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escolha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um elemento(Fogo, Água ou Planta):");
            string escolha = Console.ReadLine();

            switch (escolha)
            { 
                case "Fogo":
                    Console.WriteLine("Você escolheu o elemento Fogo!");
                    break;
                case "Água":
                    Console.WriteLine("Você escolheu o elemento Água!");
                    break;
                case "Planta":
                    Console.WriteLine("Você escolheu o elemento Planta!");
                    break;
                default:
                    Console.WriteLine("Elemento inválido!");
                    break;
            }
        }
    }
}
