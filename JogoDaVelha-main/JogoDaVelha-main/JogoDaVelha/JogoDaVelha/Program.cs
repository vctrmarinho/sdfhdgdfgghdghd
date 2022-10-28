using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    internal class Program
    {
        public static char P1 { get; set; } = '1';
        public static char P2 { get; set; } = '2';
        public static char P3 { get; set; } = '3';
        public static char P4 { get; set; } = '4';
        public static char P5 { get; set; } = '5';
        public static char P6 { get; set; } = '6';
        public static char P7 { get; set; } = '7';
        public static char P8 { get; set; } = '8';
        public static char P9 { get; set; } = '9';
        public static char simbl { get; set; } = 'X';
        public static int rodada { get; set; } = 1;



        static void Main(string[] args)
        {

            string nomeJogador1; string nomeJogador2;

            Console.WriteLine("Informe o nome do Player 1");
            nomeJogador1 = Console.ReadLine();
            Console.WriteLine($"{nomeJogador1}, seu símbolo será X ! \n");

            Console.WriteLine("Informe o nome do Player 2");
            nomeJogador2 = Console.ReadLine();
            Console.WriteLine($"{nomeJogador2}, seu símbolo será O ! \n");

            Console.WriteLine("Aperte qualquer tecla para iniciar");


            while (true)
            {

                gerarMatriz();

                verificaTurno();

                coletaPosicao(nomeJogador1, nomeJogador2);

                char pEscolhida = Convert.ToChar(Console.ReadLine());

                marcarCampo(pEscolhida);

                rodada++;

            }

            Console.ReadKey();


        }


        static void marcarCampo(char pEscolhida)
        {
              
            switch (pEscolhida)
                {
                    case '1':

                        P1 = simbl;                           
                        break;


                    case '2':

                        P2 = simbl;
                        break;

                    case '3':

                        P3 = simbl;
                        break;

                    case '4':

                        P4 = simbl;
                        break;

                    case '5':

                        P5 = simbl;
                        break;

                    case '6':

                        P6 = simbl;
                        break;

                    case '7':

                        P7 = simbl;
                        break;

                    case '8':

                        P8 = simbl;
                        break;

                    case '9':

                        P9 = simbl;
                        break;

                   
                }
}


        static void verificaTurno()
        {

            if (rodada % 2 != 0)
            {
                simbl = 'X';
            }

            else
            {
                simbl = 'O';
            }

        }


        static void gerarMatriz()
        {
            Console.Clear();
            
            Console.WriteLine("\n");
            Console.WriteLine($"  {P1}  |  {P2}  |  {P3}  ");
            Console.WriteLine("-----|-----|-----");
            Console.WriteLine($"  {P4}  |  {P5}  |  {P6}  ");
            Console.WriteLine("-----|-----|-----");
            Console.WriteLine($"  {P7}  |  {P8}  |  {P9}  ");
            Console.WriteLine("\n");



        }

        static void coletaPosicao(string play1, string play2)
        {


            if (rodada % 2 != 0)
            {
                Console.WriteLine(play1 + ", informe qual posição deseja jogar");
            }

            else
            {
                Console.WriteLine(play2 + ", informe qual posição deseja jogar");
            }


            
        }

    }
}
