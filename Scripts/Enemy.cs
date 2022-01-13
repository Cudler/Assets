using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemy", menuName = "RPG/New Enemy")]
public class Enemy : ScriptableObject
{
    public string displayName;
    public int maxHealth;
    public int weakDamage = 5;
    public int strongDamage = 10;
    public int blockDamage = 5;
    public Sprite displayIcon;

}
