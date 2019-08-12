using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Zombie zombie = new Zombie();
        Player player1 = new Player();

        zombie.Attack();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
