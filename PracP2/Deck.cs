using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracP2
{
    class Deck
    {
        public List<Card> initialCardList;

        Card[] unusedcardArray = new Card[52];
        Card[] usedcardArray = new Card[52];

        public List<int> fiftyTwoIndexes = new List<int>();

        Random rnd = new Random();
        private int _randomNumber;

        private bool _randomisedPosition = false;
        private bool _alreadyDealt = false;

        public Deck()
        {
            //Initialises the list with all 52 of the cards
            initialCardList = new List<Card>();
            for (int i = 0; i < 52; i++)
            {
                Card card = new Card(i);
                initialCardList.Add(card);
            }
            
            //Shuffles the 52 cards by assigning random indexes to each card
            foreach (Card c in initialCardList)
            {
                _randomisedPosition = false;
                //Checks using a separate list if the random index has been used. 
                //If not, the card is shuffled into the unused card list.
                while (_randomisedPosition == false)
                {
                    _randomNumber = rnd.Next(52);
                    if (!(fiftyTwoIndexes.Contains(_randomNumber)))
                    {
                        unusedcardArray[_randomNumber] = c;
                        fiftyTwoIndexes.Add(_randomNumber);
                        _randomisedPosition = true;
                    }                    
                }
            }
        }

        public Card DealCard()
        {
                _alreadyDealt = true;
                //Checks if the card have been dealt
                while (_alreadyDealt == true)
                {
                    _randomNumber = rnd.Next(52);
                    if ((fiftyTwoIndexes.Contains(_randomNumber)))
                    {
                        fiftyTwoIndexes.Remove(_randomNumber);
                        usedcardArray[_randomNumber] = unusedcardArray[_randomNumber];
                        _alreadyDealt = false;
                    }
                }
                return usedcardArray[_randomNumber]; 
            
        }
    }
}
