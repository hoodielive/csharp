using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string heroName = "Ogun";
        string equippedWeapon = "Machete";
        string favoriteFood = "Blood of a Dog";

        string favoriteLocale;
        favoriteLocale = "Forest";

        Debug.Log(heroName);
        Debug.Log(equippedWeapon);
        Debug.Log(favoriteFood);
        Debug.Log(favoriteLocale);

        Debug.Log(equippedWeapon.GetType());

        // Numbers 
        int hp = 100;
        int laserDamage = 15; 
        float shieldPower = 75.5F;
        double actualDamagePerfect = .05;

        int actualDamage = (int)(laserDamage * actualDamagePerfect);

        hp -= actualDamage;


        Debug.Log(hp);
        Debug.Log(shieldPower);
        Debug.Log("HP: " + hp);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
