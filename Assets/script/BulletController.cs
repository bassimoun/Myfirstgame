using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {
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
		if (Other.tag == "Enemy")
		{
			Destroy(Other.gameObject);
		}
		Destroy(this.gameObject);
		if (Other.tag == "Boss")
		{
			FindObjectOfType<Bossenemy> ().enemydamage(power);

		}
		Destroy(this.gameObject);
	}
}
