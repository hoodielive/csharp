using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class Main: MonoBehaviour
{
	[Serializedfield]
	private float _speed; 

	[Serializedfield]
	private float _horizontalInput;

	void update() 
	{
		// new vector3(1, 0, 0) * 5 * realtime
		transform.Translate(Vector3.right * _speed * Time.deltaTime);
		// this is what's happpening - left + right
		_horizontalInput = Input.GetAxis("Horizontal"); 
		transform.Translate(new Vector3(_horizontalInput, 0, 0) * _speed * Time.deltaTime);
	}
}
