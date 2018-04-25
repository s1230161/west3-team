using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skinSelect : MonoBehaviour {

	private GameObject hero;
	//public Transform ball;
	public static int ballnum;
	public int devideNum;
	public GameObject dami;
	// Use this for initialization
	void Start () {
		hero = GameObject.Find ("Hero");
	}

	void Update(){
		if (ballnum == devideNum)
			this.transform.position = hero.transform.position;
		else
			this.transform.position = dami.transform.position;
	}
	void OnMouseDown(){
		ballnum = devideNum;
		//Debug.Log (ballnum.ToString ());
		//colorSelect.isColor = false;
		//Instantiate (ball, hero.transform.position, Quaternion.identity);
	}
}
