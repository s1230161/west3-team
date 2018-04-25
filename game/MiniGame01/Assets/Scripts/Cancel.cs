using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cancel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnClick() {
		MyCanvas.SetActive ("Kettei", false);
		MyCanvas.SetActive ("Cancel", false);
		MyCanvas.SetActive ("Normal", true);
		MyCanvas.SetActive ("Hard", true);
		MyCanvas.SetActive ("Textcheck", false);
		MyCanvas.SetActive ("Textselect", true);

	}
}
