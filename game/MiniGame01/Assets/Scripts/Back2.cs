using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back2 : MonoBehaviour {
	public static bool b;
	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onClick(){
		gameObject.SetActive (true);
	}
	public void onClick2(){
		gameObject.SetActive (false);
	}
}
