using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kt_Jogo_Adivinhacao
{
    internal class Zebra : Animal
    {
        public string Genero { get; private set; }
        public Zebra()
        {
            Nome = "Zebra";
            Alimentacao = "Herbívora, que se alimentam, principalmente, de gramíneas";
            Habitat = "Savanas da África e demais regiões semi-desérticas";
        }
        public override void EmitirSom()
        {
            Console.WriteLine("O Animal emite um Relincho");
        }
    }
}
