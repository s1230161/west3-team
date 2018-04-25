using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kettei : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick() {
		if(MyCanvas.nanido==0)
			Application.LoadLevel ("Main");
		else if(MyCanvas.nanido==1)
			Application.LoadLevel ("Main2");
	}
}
