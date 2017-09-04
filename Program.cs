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

            string[] cards = new string[52];
            Random r = new Random();
            int k = 0;
            bool[] choice = new bool[52];
            bool done = false;
            int c = 0;
            bool moreCard = true;
            int poäng = 0;
            int poängSumma = 0;


            for (int i = 0; i < 52; i++)
            {
                choice[i] = true;
            }
            for (int i = 0; i < 13; i++)
            {
                cards[i] = "hjärter " + (i + 1);
            }
            for (int i = 13; i < 26; i++)
            {
                cards[i] = "klöver " + (i - 12);
            }
            for (int i = 26; i < 39; i++)
            {
                cards[i] = "ruter " + (i - 25);
            }
            for (int i = 39; i < 52; i++)
            {
                cards[i] = "spader " + (i - 38);
            }
            while (moreCard)
            {
                done = false;
                Console.WriteLine("Vill du dra ett kort? ");
                string pick = Console.ReadLine();
                if (pick == "ja" || pick == "Ja" || pick == "JA")
                {
                    moreCard = true;
                }
                if (pick == "nej" || pick == "Nej" || pick == "NEJ")
                {
                    moreCard = false;
                }


                if (moreCard)
                {
                    while (!done)
                    {
                        k = r.Next(0, 52);
                        if (choice[k])
                        {
                            Console.Write("Du drog kortet " + cards[k]);
                            choice[k] = false;
                            c++;
                            string[] cardsDrawn = cards[k].Split(' ');
                            poäng = Convert.ToInt32(cardsDrawn[1]);
                            poängSumma += poäng;
                            if (poängSumma > 21)
                            {
                                Console.WriteLine(", du förlorade! Du fick mer än 21");
                                done = true;
                                moreCard = false;
                            }
                            else if (poängSumma == 21)
                            {
                                Console.WriteLine(". Grattis du fick 21 och vann!");
                                Console.ReadLine();
                                return;
                            }
                            else
                            {
                                Console.WriteLine(" och din poängsumma är " + poängSumma);
                                done = true;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Din poängsumma är " + poängSumma);
                }
            }

        }
    }
}