using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kortlekssimulering
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cards = new int[52];
            Random r = new Random();
            int k = 0;
            bool[] choice = new bool[52];
            bool done = false;
            int c = 0;
            bool moreCard = true;
            string[] cardDrawn = new string[2];

            for (int i = 0; i < 52; i++)
            {
                choice[i] = true;
            }
            for (int i = 0; i < 13; i++)
            {
                cards[i] = i + 1;
            }
            for (int i = 13; i < 26; i++)
            {
                cards[i] = i - 12;
            }
            for (int i = 26; i < 39; i++)
            {
                cards[i] = i - 25;
            }
            for (int i = 39; i < 52; i++)
            {
                cards[i] = i - 38;
            }
            while (moreCard)

            {
                Console.WriteLine("Vill du dra ett kort?");
                string pick = Console.ReadLine();
                if (pick == "ja" || pick == "Ja!" || pick == "JA")
                {
                    moreCard = false;
                }

                k = r.Next(0, 52);
                if (choice[k])
                {
                    Console.WriteLine(cards[k]);
                    choice[k] = false;
                    c++;
                }
                string
            }
            Console.WriteLine(c);
        }
    }
}