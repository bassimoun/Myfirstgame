using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour {

	public int value = 5;
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
	// Update is called once per frame

}
