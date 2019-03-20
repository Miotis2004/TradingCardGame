using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour {

    [HideInInspector]
    public Card card;

    public Text descriptionText;
    public Text manaCostText;
    public Text attackValueText;
    public Text healthValueText;
    public Text nameText;

    public Image cardImage;
    
    //New variables
    public Image attackImage;
    public Image healthImage;

    public void CardSetup(Card thisCard)
    {
        card = thisCard;

        nameText.text = card.cardName;
        descriptionText.text = card.description;

        manaCostText.text = card.manaCost.ToString();

        //New functionality
        if (card.isCreature)
        {
            attackValueText.text = card.attack.ToString();
            healthValueText.text = card.health.ToString();
        }
        else
        {
            attackImage.gameObject.SetActive(false);
            healthImage.gameObject.SetActive(false);
        }
        

        cardImage.sprite = card.art;
    }
}
