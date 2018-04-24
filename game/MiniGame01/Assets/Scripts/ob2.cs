using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ob2 : MonoBehaviour {

	public Vector2 r;

	// Use this for initialization
	void Start () {
		r.x = this.transform.position.x;
		r.y = this.transform.position.y + Random.Range (0f, 5f);
		this.transform.position = r;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
