using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

public class InputManager : MonoBehaviour {

	InputField inputField;


	/// <summary>
	/// Startメソッド
	/// InputFieldコンポーネントの取得および初期化メソッドの実行
	/// </summary>
	void Start() {

		inputField = GetComponent<InputField>();

		InitInputField();

	}



	/// <summary>
	/// Log出力用メソッド
	/// 入力値を取得してLogに出力し、初期化
	/// </summary>


	public void InputLogger() {

		string inputValue = inputField.text;

		//Debug.Log(inputValue);
		ConnectionStart (inputValue);
		InitInputField();
		if(inputValue!="")
		Application.LoadLevel("Main");
	}



	/// <summary>
	/// InputFieldの初期化用メソッド
	/// 入力値をリセットして、フィールドにフォーカスする
	/// </summary>


	void InitInputField() {

		// 値をリセット
		inputField.text = "";

		// フォーカス
		inputField.ActivateInputField();
	}

	public void ConnectionStart(string inputvalue){
		StartCoroutine(Connection(inputvalue));
		Debug.Log (inputvalue);
	}

	private IEnumerator Connection(string name)
	{
		WWWForm form = new WWWForm();
		form.AddField("name", name);
		UnityWebRequest request = UnityWebRequest.Post("https://myapp.com", form);

		// リクエスト送信
		yield return request.Send();

		if (request.isError) {
			Debug.Log ("エラー:" + request.error);
		} else {
			if (request.responseCode == 204) {
				Debug.Log ("せいこう！");
			} else {
				Debug.Log ("しっぱい…:" + request.responseCode);
			}
		}
	}
}