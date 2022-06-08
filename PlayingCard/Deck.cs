using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCard
{
    public class Deck
    {
        private Card[] deck;
        private int currentCard;
        private const int number_of_cards = 52;
        private Random random;

        public Deck()
        {
            string[] ranks = {"Ace" , "Two" , "Three" , "Four" , "Five" , "Six" , "Seven" , "Eight" , "Nine" , "Ten" , "Jack" , "Queen" , "King"};
            string[] suits = {"Hearts", "Clubs", "Diamonds", "Spades"} ;
            deck = new Card[number_of_cards];
            currentCard = 0;
            random = new Random();
            for (int count = 0; count < deck.Length; count++)
                deck[count] = new Card(ranks[count % 11] , suits[count / 13]);
        }
        public void Shuffle()
        {
            currentCard = 0;
            for (int first = deck.Length - 1; first >= 1 ; first--)
            {
                int second = random.Next(number_of_cards);
                Card temp =deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }
        public Card DealCard()
        {
            if(currentCard < deck.Length)
                return deck[currentCard++];
            else
                return null;
        }
    }
}
