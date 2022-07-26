using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class deal : MonoBehaviour
{
    // List of the cards to act as a deck
    List <Card> DeckOfCards = new List<Card>();

    // Card structure to hold all the info
    struct Card
    {
        public int CardNumber;
        public string CardSuit;

        public Card(int Number, string Suit)
        {
            CardNumber = Number;
            CardSuit = Suit;
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        //generate a deck, shuffle deck

        GenDeck();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // When the button is clicked this function will run
    public void DealCard()
    {
        //Debug.Log(DeckOfCards[0].CardNumber);
    }

    //generate the cards for use within the game
    private void GenDeck()
    {
        string NewCardSuit = "";
        // Loop 52 times to make each card
        // First For loop to set the suit
        for (int i = 0; i < 4; i++)
        {
            if (i == 1)
            {
                NewCardSuit = "Hearts";
            }
            else if (i == 2)
            {
                NewCardSuit = "Spades";
            }
            else if (i == 3)
            {
                NewCardSuit = "Clubs";
            }
            else if (i == 4)
            {
                NewCardSuit = "Diamonds";
            }

            // Second For loop to set Number of cards
            for (int x = 1; x < 11; x++)
            {
                Card NewCard = new Card(x, NewCardSuit);

                DeckOfCards.Add(NewCard);
                Debug.Log(NewCard.CardSuit);
                Debug.Log(NewCard.CardNumber);
            }
        // make picture cards work


        }
         Debug.Log(DeckOfCards.Count);  
    }
 
}
