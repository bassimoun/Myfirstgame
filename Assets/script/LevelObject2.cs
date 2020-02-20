using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelObject2 : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D x)
	{
		if(x.name=="Player" && FindObjectOfType<PlayerController> ().score >= 40)
		{
			(new NavigationController ()).GoToGameScene3();


		}
	}

}
