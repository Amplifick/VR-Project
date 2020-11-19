using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : CharacterStats
{
    //Here goes code to give a certain amount of points when a zombie is killed
    private float scoreAmount;

    SpawnZombies spawn;

    GameController gameController;

    
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        spawn = gameController.GetComponentInChildren<SpawnZombies>();
        

        maxHealth = 100;
        currentHealth = 100;

        maxStamina = 100;
        currentStamina = 100;
    }

    // Update is called once per frame
    void Update()
    {
        checkHealth();
    }

    public override void Die()
    {

        //code to give points when the zombie dies needs to be implemented in this part 
        spawn.enemiesKilled++;
        Destroy(gameObject);
    }
}
