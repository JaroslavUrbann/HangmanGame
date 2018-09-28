using hangman.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace hangman.Model
{
    class RegistrujPismeno
    {
        public int chyb = 0;
        public bool pricist;
        
        public RegistrujPismeno()
        {

        }

        public string Registrace(string Slovo2, string Slovo, string _pismeno)
        {
            pricist = true;
            int a = 0;
            char[] ch = Slovo2.ToCharArray();
            Slovo2 = "";
            foreach (char i in Slovo)
            {
                if (i.ToString() == _pismeno)
                {
                    Slovo2 = Slovo2 + i;
                    pricist = false;
                }
                else
                {
                    if (i != ch[a])
                    {
                        Slovo2 = Slovo2 + "_";
                    }
                    else
                    {
                        Slovo2 = Slovo2 + i;
                    }
                }
                a++;
            }
            if (pricist) chyb++;
            return Slovo2;
        }
    }
}
