using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{

    public int currentHealth;
    public int maxHealth;
    
    public int currentStamina;
    public int maxStamina;

    public bool isDead;

    void Start()
    {
        isDead = false;
    }

    public void checkHealth()
    {
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
        if(currentHealth <= 0)
        {
            currentHealth = 0;
            isDead = true;
        }
    }

    public void checkStamina()
    {
        if (currentStamina >= maxStamina)
        {
            currentStamina = maxStamina;
        }
        if (currentStamina <= 0)
        {
            currentStamina = 0;
        }
    }

    public virtual void Die()
    {
        //Override
    }


}
