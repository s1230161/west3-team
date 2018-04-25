using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // ←※ここを追加する
public class HardButton : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnClick() {
		Debug.Log("Hard click!");
		// 非表示にする
		gameObject.SetActive(false);
		// Buttonを表示する
		MyCanvas.SetActive("Normal", false);
		MyCanvas.SetActive ("Textselect", false);
		MyCanvas.SetActive ("Textcheck", true);
		MyCanvas.nanido = 1;
		MyCanvas.SetActive ("Kettei", true);
		MyCanvas.SetActive ("Cancel", true);
		/*Debug.Log("Button click!");
		// 自分自身を無効化する
		MyCanvas.SetInteractive("Hard", false);*/
	}
}
