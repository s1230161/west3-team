using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D coll)
    {
        Vector3 v;
        v = coll.GetComponent<Rigidbody2D>().velocity;
        v.x *= -1;
        coll.GetComponent<Rigidbody2D>().velocity = v;
    }
}
