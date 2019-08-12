using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{

    public GameObject cubePrefab; 

    GameObject[] cubes = new GameObject[5];

    float spacer = 0.5f;

    void Start()
    {

        for (int i = 0; i < cubes.Length; i++)
        {
            GameObject cube = Instantiate(cubePrefab);
            cubes[i] = cube;
            cube.transform.position = new Vector3(i + (spacer * i), cube.transform.position.y); 
        }
    }

    void Update()
    {
        
    }
}
