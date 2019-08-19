using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    int health = 100;
    bool gameOver = false;

    void Start()
    {

        if (health <= 0)
        {
            gameOver = true; 
        }
        
        if (gameOver == true)
        {
            Debug.Log("The game is over!");
        }
        else
        {
            Debug.Log("You are still alive Baby!!");
        }
    }

    void Update()
    {
        
    }
}
