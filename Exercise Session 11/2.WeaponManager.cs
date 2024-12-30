using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public string[] weapons; 
    private int currentWeaponIndex = 0; 

    void Start()
    {
        weapons = new string[3];
        weapons[0] = "Gun";
        weapons[1] = "Sword";
        weapons[2] = "Hammer";

        Debug.Log("Current Weapon: " + weapons[currentWeaponIndex]);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            currentWeaponIndex++;

            if (currentWeaponIndex >= weapons.Length)
            {
                currentWeaponIndex = 0; 
            }

            Debug.Log("Switched to: " + weapons[currentWeaponIndex]);
        }

        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            currentWeaponIndex--;

            if (currentWeaponIndex < 0)
            {
                currentWeaponIndex = weapons.Length - 1; 
            }

            Debug.Log("Switched to: " + weapons[currentWeaponIndex]);
        }
    }
}