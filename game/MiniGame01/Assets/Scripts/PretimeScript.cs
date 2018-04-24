using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PretimeScript : MonoBehaviour {

	public Text preS;

	// Use this for initialization
	void Start () {
		preS.text = InputManager.resultname + " さん";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
