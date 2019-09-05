using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class CollectibleObject : MonoBehaviour 
{
	void update() 
	{
		
	}

	// use if is Trigger is set
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			// add points 
			// add abilities, etc., 
			Destroy(this.gameObject);
		}
	}
}


