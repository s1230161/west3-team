using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnTitleScript : MonoBehaviour {
	public void OnClick() {

		Application.LoadLevel ("Title");
		HeroScript.counter = 0;
	}
}
