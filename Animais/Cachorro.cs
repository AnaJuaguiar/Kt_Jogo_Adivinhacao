using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kt_Jogo_Adivinhacao
{
    class Cachorro : Animal
    {
        public int  QtdePatas { get; private set; }
        //Quando eu utilizo o private, eu digo que eu estou restringindo algo dentro de determinada classe apenas. 
        //Nesse exemplo, qualquer um pode ver o número armazenado no qtdade de patas, mas apenas quem está nessa classe pode modificar esse valor (set)
        public Cachorro()
        {
            Nome = "Cachorro";
            Alimentacao = "Originalmente carnívora";
            Habitat = "Em sua maioria, vive em ambientes domésticos";
            QtdePatas = 4; 

        }

        public override void EmitirSom()
        {
            Console.WriteLine("O Animal Late");
        }
    }
}
