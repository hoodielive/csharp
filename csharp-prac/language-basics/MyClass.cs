using System;

class MyGlass
{
	public int myField = 5; 
	public ref int GetField()
	{
		return ref myField;
	}
}