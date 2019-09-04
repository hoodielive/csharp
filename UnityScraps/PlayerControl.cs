using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public enum Weapons
    {
       Pistol = 0, Rifle = 1, ChainGun = 2, PlasmaCan = 3
    }
    // Prefab to instantiate
    public GameObject AmmoPrefab; 
    public int Ammo = 10; 
    public const int AMMO_COUNT = 15; 

    public int AmmoForPistol = AMMO_COUNT; 
    public int AmmoForRifle = AMMO_COUNT; 
    public int AmmoForChainGun = AMMO_COUNT; 


    public Weapons WeaponWeAreCarrying; 

    // Update is called once per frame; if game is 30fps, it will be called 30 times per second
    void LateUpdate()  // event being called automatically by Unity
    {
        // If fire is pressed
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (Ammo > 0)
            {
                for(int i = 0; i < 3; i++)
                {
                    // Instantiate prefab 
                    Instantiate(AmmoPrefab); 
                    Ammo -= 1; 
                }
            }
            else
            {
                Debug.Log("Out of Ammo!"); 
            }
        }
    }
}
