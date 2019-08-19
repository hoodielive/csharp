using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpTownFunction : MonoBehaviour
{
    int health = 100;
    int attackPower = 25;
    bool shieldOn = true;
    int shieldAmount = 15;

    void Start()
    {
        Debug.Log("Health at start: " + health);
    }
    public void Attack()
    {
        int damageToInflict = GetAttackDamage(shieldOn, shieldAmount, attackPower);
        health -= damageToInflict;
        Debug.Log("Health After Attack: " + health);
    }

    public void Heal()
    {
        int healAmount = GetRandomNumber();
        health += healAmount;
        Debug.Log("Received " + healAmount + " health");
        Debug.Log("You now have " + health + " health");
    }

    private int GetAttackDamage(bool isShieldOn, int theShieldAmount, int theAttackPower)
    {
        int damage = 0;
        if (isShieldOn)
        {
            damage = theAttackPower - (int)((float)theShieldAmount * 0.10f);
        }
        else
        {
            damage = theAttackPower;
        }

        return damage;
    }

    private int GetRandomNumber()
    {
        return Random.Range(2, 10);
    }
}
