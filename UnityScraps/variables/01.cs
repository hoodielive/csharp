using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class Player // : MonoBehaviour
{
	// syntax for variables
	// public (everyone) private (only script) protected ()
	// strings, bools, float, int 
	// name, opt (value)  

	public string name = "Larry"; 
	public int myAge = 19;
	public string myLocation = "everywhere";
	public bool hasKey = true; 
	public float speed = 5.5f;
	public GameObject player; 
	public Animator anim; 

	void Start() 
	{
		Debug.Log("My name is: " + name); 	
		Debug.Log("My age is: " + age); 	
		Debug.Log("My location is: " + myLocation); 	
		Debug.Log("I have the key" + hasKey); 	
	}
}