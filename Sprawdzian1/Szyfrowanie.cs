using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprawdzian1
{
    public static class Szyfrowanie
    {
        public static string ZaszyfrujCezar(string tekst, int klucz)
        {
            string zaszyfrowanyTekst = "";
            foreach (char znak in tekst)
            {
                if (Char.IsLetter(znak))
                {
                    char zaszyfrowanyZnak = (char)(((int)Char.ToUpper(znak) + klucz - 65) % 26 + 65);
                    zaszyfrowanyTekst += zaszyfrowanyZnak;
                }
                else
                {
                    zaszyfrowanyTekst += znak;
                }
            }
            return zaszyfrowanyTekst;
        }

        public static string OdszyfrujCezar(string szyfr, int klucz)
        {
            return ZaszyfrujCezar(szyfr, 26 - klucz);
        }
    }

}
