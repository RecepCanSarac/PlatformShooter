using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ability Armor", menuName = "Ability/Ability Armor")]
public class SOAbility2 : SOAbility
{
    public PlayerManager PlayerManager;
    public override void Ability()
    {
        PlayerManager.player.armor += 20;
        Debug.Log("Can Arttýrýmý Kullanýldý");
    }
}
