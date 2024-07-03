using System;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public CharacterStats player = new CharacterStats();
}

[Serializable]
public class CharacterStats
{
    public int level;
    public string name;
    public int health;
    public int speed;
    public int armor;


    public CharacterStats(int _level = 1,string name = "", int health = 0, int speed = 0, int armor = 0)
    {
        this.level = _level;
        this.name = name;
        this.health = health;
        this.speed = speed;
        this.armor = armor;
    }
}