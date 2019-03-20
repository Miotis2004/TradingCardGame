using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Targets
{
    NONE,
    ALL_CREATURES,
    ENEMY_CREATURES,
    FRIENDLY_CREATURES,
    ENEMY_HERO,
    FRIENDLY_HERO,
    ALL_CHARACTERS,
    ENEMY_CHARACTERS, 
    FRIENDLY_CHARACTERS
}

//Added CreateAssetMenu functionality
[CreateAssetMenu(fileName = "New Card", menuName = "Card")]

public class Card : ScriptableObject, IComparable<Card>
{
    [Header("Standard Info")]
    public int cardIndex;
    public string cardName;
    public string description;
    public Sprite art;
    public int manaCost;
    public Targets targets;

    [Header("Creature Info")]
    public int attack;
    public int health;
    public int maxHealth;
    public bool charge;
    public bool taunt;
    public bool isCreature;
    public int numberOfAttacks = 1;

    public int CompareTo(Card other)
    {
        return this.cardName.CompareTo(other.cardName);
    }
}
