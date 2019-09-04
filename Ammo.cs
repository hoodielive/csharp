using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    // Lifetime for ammo
    public float AmmoLife = 2.0f; 

    // speed of ammo 
    public float AmmoSpeed = 10.0f; 

    // Use this for initialization 
    IEnumerator Start() 
    {
        // Wait for ammo life time 
        yield return new WaitForSeconds(AmmoLife);

        // Destroy Ammo 
        Destroy(gameObject);
    }

    // Destroy on collision 
    void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.Translate(-Vector3.forward * AmmoSpeed * Time.deltaTime, Space.Self);
    }
    
}
