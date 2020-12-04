using Boo.Lang.Environments;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shooting : MonoBehaviour
{
    public float daño = 10f;
    public float rango = 100f;
    public Joystick shoot;

    private float runSpeed = 2f;


    private void Start()
    {
        
    }
    // Update is called once per frame


    void Update()
    {

        //shooting method


        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector2(rigidbody.velocity.y, shoot.transform.rotation.eulerAngles.y * runSpeed);

        if (Input.GetButtonDown("Fire1"))
        {
            Disparo();
        }

        void Disparo()
        {
            RaycastHit hit; 
            //Physics.Raycast(player.transform.position, player.transform.forward, out hit, rango);
        }
        
    }
}
