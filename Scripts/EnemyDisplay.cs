using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDisplay : MonoBehaviour
{
    [SerializeField] Enemy enemy;

    private void OnEnable()
    {
        GetComponentInChildren<DisplayImage>().SetImage(enemy.displayIcon);
        GetComponentInChildren<Health>().SetMaxHealth(enemy.maxHealth);
    }
}
