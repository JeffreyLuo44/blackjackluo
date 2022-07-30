using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracP2
{
    class Hand
    {
        public List<Card> handList;
        private int _totalPoints;

        public Hand()
        {
            handList = new List<Card>();
        }

        public int Total
        {
            get
            {
                _totalPoints = 0;
                foreach (Card c in handList)
                {
                    _totalPoints += c.Points;
                }
                return _totalPoints;
            }

            set
            {
                _totalPoints = value;
            }
        }
    }
}
