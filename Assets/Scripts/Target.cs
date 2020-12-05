using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update
    public float vida = 100f;
    //Here goes code to give a certain amount of points when a zombie is killed
    private float scoreAddAmount = 10;

    SpawnZombies spawn;

    GameController gameController;

    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        spawn = gameController.GetComponentInChildren<SpawnZombies>();


    }

    public void TakeDamage (float amount)
    {
        vida -= amount;
        if(vida<= 0)
        {
            Muere();
        }
    }

    void Muere()
    {
        gameController.AddScore(scoreAddAmount);

        //code to give points when the zombie dies needs to be implemented in this part 
        spawn.enemiesKilled++;
        Destroy(gameObject);
    }
}
