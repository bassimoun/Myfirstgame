using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike : MonoBehaviour {

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}
	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "soma"||other.name=="Player")
		{
			FindObjectOfType<LevelManager>().RespawnPlayer();
			FindObjectOfType<PlayerStats>().TakeDmg(10);
		}
	}
}
