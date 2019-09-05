using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 


public class Pause : MonoBehaviour
{
	void update()
	{
		// when I hit pause - stop the game 
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Time.timeScale = 0;
		}

		if (Input.GetKeyDown(KeyCode.R)) 
		{
			Time.timeScale = 1;
		}
	}
}

