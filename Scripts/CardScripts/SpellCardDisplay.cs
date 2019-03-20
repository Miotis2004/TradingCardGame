using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellCardDisplay : MonoBehaviour
{
    [HideInInspector]
    public SpellCard card;

    public Text descriptionText;
    public Text manaCostText;
    
    public Text nameText;

    public Image cardImage;

    public void CardSetup(SpellCard thisCard)
    {
        card = thisCard;

        nameText.text = card.cardName;
        descriptionText.text = card.description;

        manaCostText.text = card.manaCost.ToString();
        

        cardImage.sprite = card.art;
    }

}
