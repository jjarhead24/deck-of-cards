using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Card structure to hold all the info
public struct Card
{
    public int CardNumber;
    public string CardSuit;
    public string CardType;

    public Card(int Number, string Type, string Suit)
    {
        CardNumber = Number;
        CardSuit = Suit;
        CardType = Type;
    }
}


public class deal : MonoBehaviour
{
    // List of the cards to act as a deck
    public static List<Card> DeckOfCards = new List<Card>();
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
        int current = DeckOfCards[250].CardNumber;
        Debug.Log(current);
    }

    //generate the cards for use within the game
    private void GenDeck()
    {
        string NewCardSuit = "";
        string NewCardType = "";
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
            for (int x = 1; x < 14; x++)
            {
                if (x >= 11)
                {
                    //set card types to be what they are for picture cards
                    if (x == 11)
                    {
                        NewCardType = "Jack";
                    }
                    else if (x == 12)
                    {
                        NewCardType = "Queen";
                    }
                    else if (x == 13)
                    {
                        NewCardType = "King";
                    }
                }
                else
                {
                    NewCardType = "Number";
                }
                
                Card NewCard = new Card(x, NewCardType, NewCardSuit);

                DeckOfCards.Add(NewCard);
            }
        }
        Debug.Log(DeckOfCards.Count);  
        return;
    }
}
