using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelobject4 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D x)
	{
		if(x.name=="Player")
		{
			(new NavigationController ()).GoToGameScene5();
		}
	}
}
