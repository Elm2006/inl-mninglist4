using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;

namespace inlämninglist4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ord = new string[] { "hej", "hej", "ja" };
            char tecken = 'j';
            Console.WriteLine(FinnsTecknetIAllaSträngar(ord, tecken));
        }
        static bool FinnsTecknetIAllaSträngar(string[]ord,char tecken)
        {
            int x = 0;
            int y= 0;
            for (int i = 0; i < ord.Length; i++)
            {
                y++;
                if (ord[i].Contains(tecken))
                {
                    x++;
                }
            }
            if (x ==y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}