using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

public class InputManager : MonoBehaviour {

	InputField inputField;
	UnityWebRequest request;

	public Text errorMessage;


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
		if (inputValue.Length >= 5) {
			errorMessage.text = ("読み込み中");
			ConnectionStart (inputValue);
		}else
			errorMessage.text = ("5文字以上で入力してください。");
		InitInputField();
		//if(inputValue!="")
			//Application.LoadLevel("Main");
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
		//Debug.Log (inputvalue);
	}

	private IEnumerator Connection(string name)
	{
		WWWForm form = new WWWForm();
		form.AddField("name", name);
		request = UnityWebRequest.Post("http://192.168.11.21:3000/game/create", form);
		request.downloadHandler = new DownloadHandlerBuffer();
		//UnityWebRequest request = UnityWebRequest.Get("http://192.168.11.21:3000/game/please");
		//request.downloadHandler = (DownloadHandler) new DownloadHandlerBuffer();
		//WWW www = new WWW("http://192.168.11.21:3000/game/create",form);
		//yield return www;
		//if(www.error == null) debug
		//Debug.Log ("受け取った文字列： " + request.downloadHandler.text);

		// リクエスト送信
		yield return request.SendWebRequest();
		Debug.Log ("受け取った文字列： " + request.downloadHandler.text);
		if (request.downloadHandler.text == "0")
			errorMessage.text = (name + "はすでに使われています。");
		else if (request.downloadHandler.text == "1")
			Application.LoadLevel("Main");
		

		if (request.isNetworkError) {
			Debug.Log ("エラー:" + request.error);
		} else {
			if (request.responseCode == 200) {
				Debug.Log ("せいこう！");
			} else {
				Debug.Log ("しっぱい…:" + request.responseCode);
			}
		}
	}
}