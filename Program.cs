using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kt_Jogo_Adivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------BEM-VINDO AO JOGO DA ADIVINHAÇÃO---------");
            Console.WriteLine($"\n \n");
            Thread.Sleep(1000);
            Console.WriteLine("O jogo é composto por 3 rodadas: fácil, médio e difícil");
            Thread.Sleep(3000);
            Console.WriteLine("O objetivo do jogo é adivinhar o nome do animal de acordo com as características exibidas na tela.");
            Thread.Sleep(4000);
            Console.WriteLine("Cada animal possui 3 características e a última delas, caso você não acerte, é o som que ele faz");
            Thread.Sleep(5000);
            Console.Write("-----> ARE YOU READY???? ");
            Console.WriteLine($"\n \n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------- RODADA 1 (Nível: Fácil) ------------");
            Console.WriteLine($"\n \n");
            Animal cachorro = new Cachorro();
            Jogo jogo = new Jogo();
            jogo.Iniciar(cachorro);
            Console.WriteLine("Pressione qualquer tecla para continuar a próxima fase...");
            Console.ReadKey();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("----------- RODADA 2 (Nível: Médio) ------------");
            Console.WriteLine($"\n \n");
            Animal zebra = new Zebra();
            Jogo jogo2 = new Jogo();
            jogo2.Iniciar(zebra);
            Console.WriteLine("Pressione qualquer tecla para continuar a próxima fase...");
            Console.ReadKey();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("----------- RODADA 3 (Nível: Dificil) ------------");
            Console.WriteLine($"\n \n");
            Animal ornitorrinco = new Ornitorrinco();
            Jogo jogo3 = new Jogo();
            jogo3.Iniciar(ornitorrinco);
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();


            Console.Clear();
            Console.ResetColor();
            Console.WriteLine($"\n \n");
            Console.WriteLine($"\n \n");
            Console.WriteLine($"\n \n");
            Console.WriteLine($"\n \n");
            Console.WriteLine($"                                 OBRIGADA POR PARTICIPAR!! FIMMM :) ");
            Console.ReadKey();






        }
    }
}
