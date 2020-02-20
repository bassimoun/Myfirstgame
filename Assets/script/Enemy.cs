using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public int health;
    public int dmg;
    public int movespeed;
    public bool isfacingright;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void flip()
    {
        transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        isfacingright = !isfacingright;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "soma")
            FindObjectOfType<PlayerStats>().TakeDmg(dmg);
    }
}
