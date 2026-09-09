using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Introducao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva seu nome:");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Escreva sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade <= 13) 
            {
                Console.WriteLine("Infelizmente, você não pode jogar." + nome);
                
            }
            else
            {
                Console.WriteLine("Bem-Vindo ao Jogo! " + nome + " Sua jornada neste mundo começa agora!");
                Console.WriteLine("Em uma savana mística, onde os hipopótamos governam a sua savana a gerações, em que existem três raças de hipopótamos:");
                Console.WriteLine("Os Hipopótamo Aqua que dominam as partes das águas geladas,");
                Console.WriteLine("Os Hipopótamo Feu  que dominam as partes das \"fontes termais\" ou lugares quentes e");
                Console.WriteLine("por último os Hipopótamo Samambaia que dominam as partes terrestre que tenha muita vegetação.");
                Console.WriteLine("Uma vez a cada dez anos o rei popótamo organiza um torneio de elementares, onde quem ganhar assumi o trono.");
                // inicio do jogo, onde pede para o jogador digitar a sua idade e seu nome, nisso se ele for maior que 13 ele podera jogar.
                
            }
            Console.WriteLine("*****ESCOLHA SEU ELEMENTO*****");
            Console.WriteLine("Digite qual Hipopótamo você deseja ser (Hipopótamo feu ,Hipopótamo Aqua ou Hipopótamo Samambaia):");
            Console.WriteLine("***** RODADA 1 *****");

            string escolha = Console.ReadLine();
            string escolha_do_oponente = Console.ReadLine();
            int pontos_do_jogador = 0;
            int vida_do_jogador = 3;
            int vitorias_do_jogador = 0;
            int vitorias_do_oponente = 0;

            while(vitorias_do_jogador>3 && vitorias_do_oponente > 3)
            {
                Console.WriteLine("*****ESCOLHA SEU ELEMENTO*****");
                Console.WriteLine("Digite qual Hipopótamo você deseja ser (Hipopótamo feu ,Hipopótamo Aqua ou Hipopótamo Samambaia):");
                escolha = Console.ReadLine();
            }
            Random Escolha_Do_Oponente = new Random();
            int elemento = Escolha_Do_Oponente.Next(0, 3);
            if (elemento == 0)
            {
                escolha_do_oponente = "Hipopótamo feu";
                Console.WriteLine("O Oponente escolheu o Hipopótamo feu!");
            }
            else if (elemento == 1)
            {
                escolha_do_oponente = "Hipopótamo Aqua";
                Console.WriteLine("O Oponente escolheu o Hipopótamo aqua!");
            }
            else if (elemento == 2)
            {
                escolha_do_oponente = "Hipopótamo Samambaia";
                Console.WriteLine("O Oponente escolheu o Hipopótamo samambaia!");
            }


            switch (escolha)
            {
                case "Hipopótamo feu":

                    if (escolha_do_oponente == "Hipopótamo Aqua")
                    {
                        Console.WriteLine("O Oponente venceu a rodada!");
                        vida_do_jogador = vida_do_jogador - 1;
                        pontos_do_jogador = pontos_do_jogador - 1;
                        Console.WriteLine("PONTOS:" + pontos_do_jogador);


                    }
                    else if (escolha_do_oponente == "Hipopótamo Samambaia")
                    {
                        Console.WriteLine("Você venceu a rodada!" + nome);
                        vida_do_jogador = vida_do_jogador + 1;
                        pontos_do_jogador= pontos_do_jogador + 1;
                        Console.WriteLine("PONTOS:" + pontos_do_jogador);
                    }
                    else
                    { 
                        Console.WriteLine("Ninguem venceu a rodada, então empate!");
                        vida_do_jogador = vida_do_jogador = 0;
                        pontos_do_jogador = pontos_do_jogador = 0;
                        Console.WriteLine("PONTOS:" + pontos_do_jogador);
                    }
                    break;
                    
                case "Hipopótamo Aqua":

                    if (escolha_do_oponente == "Hipopótamo feu")
                    {
                        Console.WriteLine("Você venceu a rodada!" + nome);
                        vida_do_jogador = vida_do_jogador + 1;
                        pontos_do_jogador = pontos_do_jogador + 1;
                        Console.WriteLine("PONTOS:" + pontos_do_jogador);
                    }
                    else if (escolha_do_oponente == "Hipopótamo Samambaia")
                    {
                        Console.WriteLine("O Oponente venceu a rodada!");
                        vida_do_jogador = vida_do_jogador - 1;
                        pontos_do_jogador = pontos_do_jogador - 1;
                        Console.WriteLine("PONTOS:" + pontos_do_jogador);
                    }
                    else
                    {
                        Console.WriteLine("Ninguem venceu a rodada, então empate!");
                        vida_do_jogador = vida_do_jogador = 0;
                        pontos_do_jogador = pontos_do_jogador = 0;
                        Console.WriteLine("PONTOS:" + pontos_do_jogador);

                    }
                    break;

                case "Hipopótamo Samambaia":
                    if (escolha_do_oponente == "Hipopótamo feu")
                    {
                        Console.WriteLine("O Oponente venceu a rodada!");
                        vida_do_jogador = vida_do_jogador - 1;
                        pontos_do_jogador = pontos_do_jogador - 1; 
                        Console.WriteLine("PONTOS:" + pontos_do_jogador);
                    }
                    else if (escolha_do_oponente == "Hipopótamo Aqua")
                    {
                        Console.WriteLine("Você venceu a rodada!" + nome);
                        vida_do_jogador = vida_do_jogador + 1;
                        pontos_do_jogador = pontos_do_jogador + 1;
                        Console.WriteLine("PONTOS:" + pontos_do_jogador); 
                    }
                    else
                    {
                        Console.WriteLine("Ninguem venceu a rodada, então empate!");
                        vida_do_jogador = 0;
                        pontos_do_jogador = 0;
                        Console.WriteLine("PONTOS:" + pontos_do_jogador);
                    }

                    break;
            } 
        }
    }
}
