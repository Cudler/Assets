using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth;

    [SerializeField] private Image healthForeground;
    [SerializeField] private TextMeshProUGUI healthText;

    private int currentHealth;

    private void OnEnable()
    {
        if(maxHealth == 0)
            enabled = false;

        SetHealth(maxHealth);
    }

    public void SetMaxHealth(int val)
    {
        maxHealth = val;
    }

    private void SetHealth(int value)
    {
        value = Mathf.Clamp(value, 0, maxHealth);
        currentHealth = value;
        float fillAmount = (float)value / maxHealth;
        healthForeground.fillAmount = fillAmount;
        healthText.text = value + "/" + maxHealth;

    }

    public void DamageHealth(int damage)
    {
        SetHealth(currentHealth - damage);
    }

}
