using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletboss : MonoBehaviour {
	public float speed;
	public int power;
	private PlayerController Player;

	void Start () {
		Player = FindObjectOfType<PlayerController>();
		if (Player.transform.localScale.x < 0)
		{
			speed = -speed;
		}

	}


	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
		Destroy (gameObject, 3f);

	}

	void OnTriggerEnter2D(Collider2D Other)
	{
		if (Other.name == "Player")
		{
			
			FindObjectOfType<PlayerStats> ().TakeDmg(10);

		}
		if (Other.tag == "Wall")
		{
			Destroy(this.gameObject);
		}
	}
}
