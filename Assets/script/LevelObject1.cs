using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelObject1 : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D x)
	{
		if(x.name=="Player" && FindObjectOfType<PlayerController> ().score >= 35)
		{
			(new NavigationController ()).GoToGameScene2();
		}
	}
}
