using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100;
        currentHealth = maxHealth;
        

        maxStamina = 100;
        currentStamina = maxStamina;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Die()
    {
        Debug.Log("You died");
    }
}
