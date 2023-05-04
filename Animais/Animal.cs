using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kt_Jogo_Adivinhacao
{
    public abstract class Animal
    {
        public string Nome { get; protected set; }
        public string Alimentacao { get; protected set; }
        public string Habitat { get; protected set; }

        public Animal()
        {

        }

        public abstract void EmitirSom();


    }
}
