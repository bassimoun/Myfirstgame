using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	public GameObject currentCheckpoint;
	public Transform Enemy;

	void Start () 
	{

	}

	// Update is called once per frame
	void Update () {

	}

	public void RespawnPlayer()
	{
		Debug.Log("Player has Respawned");
		FindObjectOfType<PlayerController>().transform.position = currentCheckpoint.transform.position;
	} 
	public void RespawnEnemy()
	{
		Instantiate(Enemy, transform.position, transform.rotation);
	}
}
