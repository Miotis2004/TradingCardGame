using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeckSaver : MonoBehaviour
{

    public Deck deck;
    public Text deckName;

    public void SaveDeck()
    {
        if (deck == null)
        {
            return;
        }

        

        for (int i = 0; i < deck.cards.Count; i++)
        {
            PlayerPrefs.SetInt(deck.deckName + i.ToString(), deck.cards[i].cardIndex);
        }

        deckName.text = deck.deckName;
    }


}
