using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float movespeed;
	public float height;
	public KeyCode L;
	public KeyCode R;
	public KeyCode U;
	public KeyCode D;
	public bool isFacingRight;
	public Transform GroundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;
	public float x;
	public float y;
	public float z;
	private Animator anim;
	public int score;
	public KeyCode shoot;
	public Transform firePoint;
	public GameObject bullet;
	public AudioClip jump1;
	public AudioClip fire;
	// Use this for initialization
	void Start () {
		x = transform.localScale.x;
		y = transform.localScale.y;
		z = transform.localScale.z;
		isFacingRight = true;
		anim = GetComponent<Animator>();
	}

	void flip()
	{
		if (GetComponent<Rigidbody2D>().velocity.x > 0)
		{
			transform.localScale = new Vector3(x, y, z);
		}

		else if(GetComponent<Rigidbody2D>().velocity.x < 0)
		{
			transform.localScale = new Vector3(-x, y, z);
		}

	}
	void jump()
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, height);
		AudioManger.instance.RandomizeSfx (jump1);
		anim.SetBool("Grounded", false);
	}
	void FixedUpdate()
	{
		grounded = Physics2D.OverlapCircle(GroundCheck.position, groundCheckRadius, whatIsGround);

	
	}
	// Update is called once per frame
	void Update () {
		anim.SetBool("Grounded", grounded);
		anim.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
		if (Input.GetKey(L))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(-movespeed, GetComponent<Rigidbody2D>().velocity.y);

			if(isFacingRight)
			{
				flip();
				isFacingRight = false;
			}
		}

		if (Input.GetKey(R))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed, GetComponent<Rigidbody2D>().velocity.y);

			if(!isFacingRight)
			{
				flip();
				isFacingRight = true;
			}
		}


		if (Input.GetKey(U) && grounded==true)
		{
			jump();

		} 


		if(Input.GetKey(D))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, -movespeed);
		}

		if (Input.GetKeyDown (shoot)) {
			anim.SetBool("isShooting", true);
			Instantiate (bullet, firePoint.position, firePoint.rotation);
			AudioManger.instance.RandomizeSfx (fire);
		}
		else
			anim.SetBool("isShooting", false);

	}

}
