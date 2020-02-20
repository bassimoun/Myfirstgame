using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

	public Transform target;
	public float smoothing;
	private Vector3 offset;
	// Use this for initialization
	void Start () {

		offset = transform.position - target.position;
	}

	// Update is called once per frame
	void FixedUpdate () {
		Vector3 targetcampos = target.position + offset;
		transform.position = Vector3.Lerp(transform.position, targetcampos, smoothing * Time.deltaTime);
	}
}
