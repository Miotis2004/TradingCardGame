using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour {

    public string deckName;
    public List<Card> cards = new List<Card>();

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

}
