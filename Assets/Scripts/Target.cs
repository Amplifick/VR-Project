using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update
    public float vida = 50f;

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
        Destroy(gameObject);
    }
}
