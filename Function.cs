using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
	}
	float Sum(float a, float b)
	{
        return  a + b;
	}
	float Prod(float a, float b)
    {
		return a * b;
    }
	float Div(float a, float b)
	{
		if (b == 0)
        {
			Debug.Log("error");
			return -1;

        }
	
		else
		return a / b;
    }
}