using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kt_Jogo_Adivinhacao
{
    internal class Jogo
    {
        public string Palpite { get; set; }
        public bool Acertou { get; set; }
        public bool Comparar(string nome1, string nome2)
        {
            if (nome1.ToLower() == nome2.ToLower())
                return true;
            else
                return false;
        }

        public void Iniciar(Animal x)
        {
            Console.WriteLine("----------Tentativa 1---------");
            Console.WriteLine($"\n");
            Console.WriteLine($"Tipo de Alimentação: {x.Alimentacao}");
            Console.Write("Seu palpite: ");
            Palpite = Console.ReadLine();
            Acertou = Comparar(Palpite, x.Nome);

            if(Acertou != true)
            {
                Thread.Sleep(2000);
                Console.WriteLine($"\n");

                Console.WriteLine("Você errou :( Maaaasss....  vamos continuar.");
                
                Console.WriteLine($"\n \n");
                Console.WriteLine("----------Tentativa 2: ----------");
                Console.WriteLine($"\n");

                Console.WriteLine($"Tipo de Habitat: {x.Habitat}");

                Console.Write("Seu palpite: ");
                Palpite = Console.ReadLine();

                Acertou = Comparar(Palpite, x.Nome);

                if (Acertou != true)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine($"\n");
                    Console.WriteLine("Você errou :( Maaaasss....  vamos continuar.");
                    Console.WriteLine($"\n \n");
                    Console.WriteLine("----------Última Tentativa: ----------");
                    Console.WriteLine($"\n");

                    Console.Write($"Tipo de Som: ");
                    x.EmitirSom();
                    Console.Write("Seu palpite: ");
                    Palpite = Console.ReadLine();
                    Acertou = Comparar(Palpite, x.Nome);

                    if (Acertou == true)
                    {
                        Console.WriteLine($"\n");
                        Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Você Acertou!! (Mas foi por pouco!) ");
                    }
                    else
                    {
                        Console.WriteLine($"\n");
                        Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Você errou :(  O animal era: {x.Nome} ");
                    }

                }
                else
                {
                    Console.WriteLine($"\n");
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Você Acertou!! ");

                }
                
            }
            else{
                    Console.WriteLine($"\n");
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ACERTOU DE PRIMEIRAAAA!!");

            }




        }

    }
}
