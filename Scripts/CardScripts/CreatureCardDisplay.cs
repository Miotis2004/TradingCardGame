using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatureCardDisplay : MonoBehaviour {
    [HideInInspector]
    public CreatureCard card;

    public Text descriptionText;
    public Text manaCostText;
    public Text attackValueText;
    public Text healthValueText;
    public Text nameText;

    public Image cardImage;

    public void CardSetup(CreatureCard thisCard)
    {
        card = thisCard;

        nameText.text = card.cardName;
        descriptionText.text = card.description;

        manaCostText.text = card.manaCost.ToString();
        attackValueText.text = card.attack.ToString();
        healthValueText.text = card.health.ToString();

        cardImage.sprite = card.art;
    }



}
