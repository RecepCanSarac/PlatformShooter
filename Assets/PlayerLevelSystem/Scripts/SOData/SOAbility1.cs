
using UnityEngine;

[CreateAssetMenu(fileName = "Ability Health", menuName = "Ability/Ability Health")]
public class SOAbility1 : SOAbility
{
    public PlayerManager PlayerManager;
    public override void Ability()
    {
        PlayerManager.player.health += 20;
        Debug.Log("Can Arttýrýmý Kullanýldý");
    }
}
