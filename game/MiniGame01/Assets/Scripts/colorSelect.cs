using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorSelect : MonoBehaviour {

	public GameObject hero;
	public static Color heroColor = new Color (0f, 255f, 0f, 255f);
	public Color eachColor;
	public static bool isColor = true;

	void Start(){
		hero.gameObject.GetComponent<SpriteRenderer> ().color = heroColor;
	}

	void OnMouseDown(){
		skinSelect.ballnum = 0;
		//Debug.Log (skinSelect.ballnum.ToString ());
		hero.gameObject.GetComponent<SpriteRenderer>().color = eachColor;
		heroColor = eachColor;
	}

	public static Color getColor(){
		return heroColor;
	}
		
}
