using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bossenemy : MonoBehaviour{
	public AudioClip fire;
	public int health ;
	public GameObject bullet;
	public Transform firepoint;
	public float shootingtime;
	public float shootingduration;
	private Animator anim;
	public int movespeed;
	public bool isfacingright;
	public SpriteRenderer sp;
	public Slider healthbar;

	public void flip()
	{
		transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);
		isfacingright = !isfacingright;
	}


	public void enemydamage(int d){
		health -= d;
		if (health < 0)
		{
			health = 0;
		}
		if (health == 0)
		{
			Destroy (this.gameObject);

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
	void Start()
	{

		anim = GetComponent<Animator>();
	}
	void Update()
	{

		if (shootingtime < shootingduration) {
			shootingtime += Time.deltaTime;
		}
		else
		{
			anim.SetBool("isShootingenemy", true);
			Instantiate (bullet, firepoint.position, firepoint.rotation);
			shootingtime = 0;
			AudioManger.instance.RandomizeSfx (fire);
		}
		healthbar.value = health;
	}
}

