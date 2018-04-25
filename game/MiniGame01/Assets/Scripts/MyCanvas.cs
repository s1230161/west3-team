using UnityEngine;
using System.Collections;
using UnityEngine.UI; // ←※ここを追加する

public class MyCanvas : MonoBehaviour {
	public static int nanido;

	static Canvas canvas;
	void Start () {
		// Canvasコンポーネントを保持
		canvas = GetComponent<Canvas>();
	}

	/// 表示・非表示を設定する
	public static void SetActive(string name, bool b) {
		foreach(Transform child in GameObject.Find("Canvas").transform) {
			// 子の要素をたどる
			if(child.name == name) {
				Debug.Log (name);
				// 指定した名前と一致
				// 表示フラグを設定
				child.gameObject.SetActive(b);
				// おしまい
				return;
			}
		}
		// 指定したオブジェクト名が見つからなかった
		Debug.LogWarning("Not found objname:"+name);
	}

	/// ボタンの有効・無効を設定する
	public static void SetInteractive(string name, bool b) {
		foreach(Transform child in GameObject.Find("Canvas").transform) {
			// 子の要素をたどる
			if(child.name == name) {
				// 指定した名前と一致
				// Buttonコンポーネントを取得する
				Button btn = child.GetComponent<Button>();
				// 有効・無効フラグを設定
				btn.interactable = b;
				// おしまい
				return;
			}
		}
		// 指定したオブジェクト名が見つからなかった
		Debug.LogWarning("Not found objname:"+name);
	}

	public static void SetTextActive(string name, bool b) {
		foreach(Transform child in GameObject.Find("back2").transform) {
			// 子の要素をたどる
			if(child.name == name) {
				Debug.Log (name);
				// 指定した名前と一致
				// 表示フラグを設定
				child.gameObject.SetActive(b);
				// おしまい
				return;
			}
}
	}
}
