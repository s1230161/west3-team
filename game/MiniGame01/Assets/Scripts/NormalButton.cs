using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // ←※ここを追加する
public class NormalButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		MyCanvas.SetActive ("Textcheck", false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick() {
		Debug.Log("Normal click!");
		// 非表示にする
		gameObject.SetActive(false);
		Debug.Log ("ll");
		// Buttonを表示する
		MyCanvas.SetActive("Hard", false);
		MyCanvas.SetActive ("Textselect", false);
		MyCanvas.SetActive ("Textcheck", true);
		MyCanvas.nanido = 0;
		MyCanvas.SetActive ("Kettei", true);
		MyCanvas.SetActive ("Cancel", true);
		/*Debug.Log("Button click!");
		// 自分自身を無効化する
		MyCanvas.SetInteractive("Normal", false);*/
	}
}
