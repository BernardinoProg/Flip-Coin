using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin.Models
{
    public class Coin
    {
        public int Lado { get; set; }
        public int LadoEscolhido { get; set; }

        public Coin()
        {
            
        }

        public string Jogar()
        {
            return new Random().Next(2) == 0 ? "Cara" : "Coroa";
        }
    }
}
