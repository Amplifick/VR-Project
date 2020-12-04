using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchJoystickRotation : MonoBehaviour
{
	public Joystick joystick;
	public GameObject Object;
	Vector2 GameobjectRotation;
	private float GameobjectRotation2;
	public float daño = 10f;
	public float rango = 100f;


	public bool FacingRight = true;
	
	void Update()
	{
		//Gets the input from the jostick
		GameobjectRotation = new Vector2(joystick.Horizontal, joystick.Vertical);

		
		GameobjectRotation2 = GameobjectRotation.x + GameobjectRotation.y * 360;
		Object.transform.rotation = Quaternion.Euler(0f, GameobjectRotation2, 0f);


		if (joystick.isActiveAndEnabled)
		{

			disparo();

		}
		
		
		
		
	}

	void disparo()
	{
		RaycastHit hit;
		if(Physics.Raycast(Object.transform.position, Object.transform.forward, out hit, rango))
			{

			Target target = hit.transform.GetComponent<Target>();
			if(target != null)
			{
				target.TakeDamage(daño);
			}
		}

	}


}
