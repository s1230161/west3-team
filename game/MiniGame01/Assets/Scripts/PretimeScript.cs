using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PretimeScript : MonoBehaviour {

	public Text Uname;

	// Use this for initialization
	void Start () {
		Uname.text = InputManager.resultname + " さん";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
