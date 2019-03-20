using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Hero Power", menuName = "Players/Hero Power")]
public class HeroPower : ScriptableObject
{

    public int damage;
    public int heal;
    public int armor;
}
