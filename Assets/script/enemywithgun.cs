using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemywithgun : Enemy{
	public AudioClip fire;
	public GameObject bullet;
	public Transform firepoint;
	public float shootingtime;
	public float shootingduration;
	private Animator anim;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "soma")
		{
			FindObjectOfType<PlayerStats>().TakeDmg(5);
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
			anim.SetBool("isShooting", true);
			Instantiate (bullet, firepoint.position, firepoint.rotation);
			shootingtime = 0;
			AudioManger.instance.RandomizeSfx (fire);
		}
	}
}
