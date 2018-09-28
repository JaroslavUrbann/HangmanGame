using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman.Model
{
    class RandomSlovo
    {
        public string[] names = System.IO.File.ReadAllLines(@"slova.txt");
        public RandomSlovo()
        {
            
        }

        public string GenerujSlovo()
        {
            Random rnd = new Random();
            return names[rnd.Next(1,855)];
        }
    }
}
