using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class Player: MonoBehaviour
{
	public vector3 startPostion; 

	startPosition = new Vector3(0, 0, 0);
	// use initialization 
	void Start()
	{
		transform.postion = startPosition; 
	}
}
