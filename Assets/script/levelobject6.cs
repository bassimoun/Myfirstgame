using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelobject6 : MonoBehaviour {
	public AudioClip win;
	void OnTriggerEnter2D(Collider2D x)
	{
		if(x.name=="Player")
		{
			(new NavigationController ()).GoToVictoryScene();
			AudioManger.instance.PlaySingle (win);
			AudioManger.instance.musicSource.Stop ();
		}
	}
}
