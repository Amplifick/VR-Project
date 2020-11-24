using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject primary, secondary;
    public int weaponSelected;
        

    public void Start()
    {
        weaponSelected = 2;
        swapWeapon(2);

    }

    // Update is called once per frame
    public void Update()
    {
        if (weaponSelected !=1)
        {
            swapWeapon(1);
            
        } else if (weaponSelected !=2)
        {
            swapWeapon(2);
            weaponSelected = 2;
        }
    }

   public void swapWeapon(int weaponType)
    {
        if (weaponType==1)
        {
            primary.SetActive(true);
            secondary.SetActive(false);
            weaponSelected = 1;
        }

        if (weaponType == 2)
        {
            primary.SetActive(false);
            secondary.SetActive(true);
            weaponSelected = 2;
        }
    }
}
