using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food2 : MonoBehaviour {

	public int value = 10;
	public AudioClip coin1;
	// Use this for initialization


	void OnTriggerEnter2D(Collider2D x)
	{
		if(x.name=="Player")
		{
			AudioManger.instance.RandomizeSfx (coin1);
			FindObjectOfType<PlayerController>().score += value;
			Destroy(this.gameObject);
		}
	}
}
