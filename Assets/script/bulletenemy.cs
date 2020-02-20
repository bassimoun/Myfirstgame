using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletenemy : MonoBehaviour {
	public float speed;
	public int dmg = 5;
	private enemywithgun enemy2;
	void Start () {

		enemy2 = FindObjectOfType<enemywithgun>();
		if (enemy2.transform.localScale.x < 0)
		{
			speed = -speed;
		}
	}


	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
		Destroy (gameObject, 3f);


	}
	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "soma")
		{
			FindObjectOfType<PlayerStats>().TakeDmg(dmg);
	     }
		if (other.tag == "Enemy")
		{
			Destroy(other.gameObject);
		}
		if (other.tag == "Wall")
		{
			Destroy(this.gameObject);
		}
	}
}
