using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingEnemy : Enemy {
	public AudioClip hit1;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "soma")
		{
			AudioManger.instance.RandomizeSfx (hit1);
			FindObjectOfType<PlayerStats>().TakeDmg(3);
		}
		else if(other.tag == "Enemy")
		{
			flip();
		}
		else if(other.tag == "Wall")
		{
			flip();
		}
	}

	void FixedUpdate()
	{
		if (isfacingright)
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed, GetComponent<Rigidbody2D>().velocity.y);
		}
		else
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(-movespeed, GetComponent<Rigidbody2D>().velocity.y);
		}

	}

}
