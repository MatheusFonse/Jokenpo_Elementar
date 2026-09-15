using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
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

                return;



            }


            else
            {


                Console.WriteLine("Bem-Vindo ao Jogo! " + nome + " Sua jornada neste mundo começa agora!");


                Console.WriteLine("Em uma savana mística, onde os Tapaumus usam hipopótamos para governa a sua savana a gerações em gerações, em que existem três raças de hipopótamos:");


                Console.WriteLine("Os Hipopótamo Aqua que dominam as partes das águas geladas,");


                Console.WriteLine("Os Hipopótamo Feu  que dominam as partes das fontes termais ou lugares quentes e");


                Console.WriteLine("por último os Hipopótamo Samambaia que dominam as partes terrestre que tenha muita vegetação.");


                Console.WriteLine("Uma vez a cada dez anos o rei popótamo organiza um torneio de elementares, onde quem ganhar assumi o trono.");


                // inicio do jogo, onde pede para o jogador digitar a sua idade e seu nome, nisso se ele for maior que 13 ele podera jogar.

            }


            int vitorias_do_jogador = 0;


            int vitorias_do_oponente = 0;


            int pontos_do_jogador = 0;


            int vida_do_jogador = 8;


            while (vitorias_do_jogador < 8 && vitorias_do_oponente < 8)


            {


                if (vida_do_jogador <= 0)


                {


                    Console.WriteLine("Voce perdeu o jogo!" + nome);


                    return;


                }


                else if (pontos_do_jogador == 8)


                {


                    Console.WriteLine("Voce venceu o jogo!" + nome);


                    return;




                }


                else
                {


                    Console.WriteLine();



                }



                Console.WriteLine("*****ESCOLHA SEU ELEMENTO*****");
                Console.WriteLine("Hipopótamo feu (Hot Bear) - Pedra, Salzeiro: Se o jogador vencer, ele ganha +4 pontos.");
                Console.WriteLine("Hipopótamo Aqua (Ice Bear) - Papel, Picolezin: Se o jogador vencer, ele ganha +3 pontos. ");
                Console.WriteLine("Hipopótamo Samambaia (Nathe Bear) - Tesoura, Gengibrin: Se o jogador vencer, ele ganha +2 pontos. ");
                Console.WriteLine("Digite qual Hipopótamo você deseja ser (Hipopótamo feu ,Hipopótamo Aqua ou Hipopótamo Samambaia):");





                string escolha = Console.ReadLine();


                string escolha_do_oponente = Console.ReadLine();




                {



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


                            Console.WriteLine("O Oponente venceu a rodada, pois a água apaga o Brazão deixando ela sem poder !");

                            Console.WriteLine("Hipopótamo Aqua usou Ice Bear (Pedra)");

                            vida_do_jogador = vida_do_jogador - 3;


                            pontos_do_jogador = pontos_do_jogador - 1;


                            Console.WriteLine("PONTOS:" + pontos_do_jogador);


                            Console.WriteLine($"{nome} está com {vida_do_jogador} de vida");




                        }


                        else if (escolha_do_oponente == "Hipopótamo Samambaia")


                        {


                            Console.WriteLine("Você venceu a rodada!" + nome + ", pois o Brazão queima a samambaia, deixando ela invulnerável !");

                            Console.WriteLine("Hipopótamo feu usou Hot Bear (Tesoura)");

                            pontos_do_jogador = pontos_do_jogador + 4;


                            Console.WriteLine("PONTOS:" + pontos_do_jogador);


                            Console.WriteLine($"{nome} está com {vida_do_jogador} de vida");


                        }


                        else
                        {


                            Console.WriteLine("Ninguem venceu a rodada, então empate!");


                            Console.WriteLine("PONTOS:" + pontos_do_jogador);


                            Console.WriteLine($"{nome} está com {vida_do_jogador} de vida");


                        }


                        break;



                    case "Hipopótamo Aqua":



                        if (escolha_do_oponente == "Hipopótamo feu")


                        {


                            Console.WriteLine("Você venceu a rodada!" + nome + ", pois a água apaga o Brazão deixando ela sem poder !");

                            Console.WriteLine("Hipopótamo Aqua usou Ice Bear (Pedra)");

                            pontos_do_jogador = pontos_do_jogador + 3;


                            Console.WriteLine("PONTOS:" + pontos_do_jogador);


                            Console.WriteLine($"{nome} está com {vida_do_jogador} de vida");


                        }


                        else if (escolha_do_oponente == "Hipopótamo Samambaia")


                        {


                            Console.WriteLine("O Oponente venceu a rodada, A samambaia suga a água e a planta fica mais forte!");

                            Console.WriteLine("Hipopótamo Samambaia usou Nathe Bear (Papel)");


                            vida_do_jogador = vida_do_jogador - 2;


                            pontos_do_jogador = pontos_do_jogador - 1;


                            Console.WriteLine("PONTOS:" + pontos_do_jogador);


                            Console.WriteLine($"{nome} está com {vida_do_jogador} de vida");


                        }


                        else
                        {


                            Console.WriteLine("Ninguem venceu a rodada, então empate!");


                            Console.WriteLine("PONTOS:" + pontos_do_jogador);


                            Console.WriteLine($"{nome} está com {vida_do_jogador} de vida");



                        }


                        break;



                    case "Hipopótamo Samambaia":


                        if (escolha_do_oponente == "Hipopótamo feu")


                        {


                            Console.WriteLine("O Oponente venceu a rodada,O Brazão queima a samambaia, deixando ela invulnerável!");

                            Console.WriteLine("Hipopótamo feu usou Hot Bear (Tesoura)");


                            vida_do_jogador = vida_do_jogador - 4;


                            pontos_do_jogador = pontos_do_jogador - 1;


                            Console.WriteLine($"PONTOS: {pontos_do_jogador}");


                            Console.WriteLine($"{nome} está com {vida_do_jogador} de vida");


                        }


                        else if (escolha_do_oponente == "Hipopótamo Aqua")


                        {


                            Console.WriteLine("Você venceu a rodada!" + nome + " A samambaia suga a água e a planta fica mais forte!");

                            Console.WriteLine("Hipopótamo Samambaia usou Nathe Bear (Papel)");


                            pontos_do_jogador = pontos_do_jogador + 2;


                            Console.WriteLine("PONTOS:" + pontos_do_jogador);


                            Console.WriteLine($"{nome} está com {vida_do_jogador} de vida");


                        }


                        else
                        {


                            Console.WriteLine("Ninguem venceu a rodada, então empate!");


                            Console.WriteLine("PONTOS:" + pontos_do_jogador);


                            Console.WriteLine($"{nome} está com {vida_do_jogador} de vida");


                        }



                        break;
                    
                    

                }



            }



        }


    }


}
        
    

