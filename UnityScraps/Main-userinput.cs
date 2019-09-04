using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class Main: MonoBehaviour
{
	void Start() 
	{
		
	}
	
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Debug.Log("Space Key Down"); 
		}

		if (Input.GetKey(KeyCode.E)) 
		{
			Debug.Log("Holding E");
		}

		if (Input.GetKeyUp(KeyCode.F))
		{
			Debug.Log("You lifted your finger off of F");
		}
	}
}
