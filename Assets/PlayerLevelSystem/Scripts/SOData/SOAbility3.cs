using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Ability Speed", menuName = "Ability/Ability Speed")]
public class SOAbility3 : SOAbility
{
    public PlayerManager PlayerManager;
    public override void Ability()
    {
        PlayerManager.player.speed += 20;
        Debug.Log("Can Arttýrýmý Kullanýldý");
    }
}
