using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman.Model
{
    class NovaHra
    {
        RandomSlovo RS = new RandomSlovo();
        public string slovo;

        public NovaHra()
        {

        }

        public string VraceckaSlova()
        {
            slovo = RS.GenerujSlovo();
            return slovo;
        }

        public string VraceckaSlova2()
        {
            string slovo2 = "";
            foreach (char i in slovo)
            {
                slovo2 = slovo2 + "_";
            }
            return slovo2;
        }
    }
}
