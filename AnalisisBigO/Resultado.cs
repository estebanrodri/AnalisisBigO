using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisBigO
{
    internal class Resultado
    {

        public Resultado(int elResultado, string losValores)
        {
            this.elResultado = elResultado;
            LosValores = losValores;
        }

        public int elResultado { get; set; }
        public string LosValores { get; set; }


    }
}
