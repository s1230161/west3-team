using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goToRanking : MonoBehaviour {
	public void OnClick() {

		Application.LoadLevel ("Ranking");
		HeroScript.counter = 0;
	}
}
