using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroDisplay : MonoBehaviour
{
    public Text healthText;
    public Text armorText;
    public Text attackText;

    public Image heroAvatar;

    private Hero myHero;

    public void HeroSetup(Hero thisHero)
    {
        myHero = thisHero;

        healthText.text = myHero.health.ToString();
        armorText.text = myHero.armor.ToString();
        attackText.text = myHero.attack.ToString();

        heroAvatar.sprite = myHero.avatar;
    }



	
}
