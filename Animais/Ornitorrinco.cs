using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kt_Jogo_Adivinhacao
{
    internal class Ornitorrinco : Animal
    {
        public Ornitorrinco()
        {
            Nome = "Ornitorrinco";
            Alimentacao = "Alimenta-se principalmente de insetos invertebrados que habitam o fundo dos corpos d'água";
            Habitat = "É um mamífero semiaquático natural da Austrália e Tasmânia";
        }
        public override void EmitirSom()
        {
            Console.WriteLine("O Animal emite sons peculiares, como grunhidos, assobios e gemidos");
        }
    }
}
