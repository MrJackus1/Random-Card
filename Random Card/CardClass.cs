using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Card
{
    class CardClass
    {
        private int Card, Suit;
        private string sCard, sSuit, Ans;

        public string Carding(int Card, int Suit)
        { 
            if (Card == 1)
            {
                sCard = "Ace";
            }
            else if (Card == 2)
            {
                sCard = "Two";
            }
            else if (Card == 3)
            {
                sCard = "Three";
            }
            else if (Card == 4)
            {
                sCard = "Four";
            }
            else if (Card == 5)
            {
                sCard = "Five";
            }
            else if (Card == 6)
            {
                sCard = "Six";
            }
            else if (Card == 7)
            {
                sCard = "Seven";
            }
            else if (Card == 8)
            {
                sCard = "Eight";
            }
            else if (Card == 9)
            {
                sCard = "Nine";
            }
            else if (Card == 10)
            {
                sCard = "Ten";
            }
            else if (Card == 11)
            {
                sCard = "Jack";
            }
            else if (Card == 12)
            {
                sCard = "Queen";
            }else if (Card == 13)
            {
                sCard = "King";
            }

            if (Suit == 1)
            {
                sSuit = "Hearts";
            }else if (Suit == 2)
            {
                sSuit = "Spades";
            }else if (Suit == 3)
            {
                sSuit = "Clubs";
            }else if (Suit == 4)
            {
                sSuit = "Diamonds";
            }
            



            Ans = sCard + " of " + sSuit;
            return Ans;

        }

    }
}
