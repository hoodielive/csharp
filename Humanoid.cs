using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humanoid : MonoBehaviour
{

    private int health;
    protected int attackDamage;
    private float movementSpeed;

    public virtual void TakeDamage(int damageToTake)
    {
        health -= damageToTake;
    }
    public virtual int Attack => 0;

    public virtual void Move()
    {

        transform.Translate(Vector3.forward * Time.deltaTime);
    }

    public void Die()
    {

    }
}
