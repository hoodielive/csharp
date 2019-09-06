using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class Player : MonoBehaviour
{
	// syntax for variables
	// public (everyone) private (only script) protected ()
	// strings, bools, float, int 
	// name, opt (value)  

	public string name = "Larry"; 
	public int myAge = 19;
	public string myLocation "everywhere";
	void Start() 
	{
		Debug.Log("My name is: " + name); 	
		Debug.Log("My age is: " + age); 	
		Debug.Log("My location is: " + myLocation); 	
	}

	void Update() 
	{

	}
	
}

