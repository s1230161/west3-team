using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class ResultDisplay : MonoBehaviour {

	public Text score;
	UnityWebRequest request;

	// Use this for initialization
	void Start () {
		
		score.text = HeroScript.getScore ().ToString();
		ConnectionStart (InputManager.resultname,HeroScript.getScore ());

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ConnectionStart(string name,int score){
		StartCoroutine(Connection(name,score));
	}

	private IEnumerator Connection(string name,int score)
	{
		WWWForm form = new WWWForm();
		form.AddField("name", name);
		form.AddField("score", score);
		request = UnityWebRequest.Post("http://192.168.11.21:3000/game/finish_score", form);
		request.downloadHandler = new DownloadHandlerBuffer();
		//UnityWebRequest request = UnityWebRequest.Get("http://192.168.11.21:3000/game/please");
		//request.downloadHandler = (DownloadHandler) new DownloadHandlerBuffer();
		//WWW www = new WWW("http://192.168.11.21:3000/game/create",form);
		//yield return www;
		//if(www.error == null) debug
		//Debug.Log ("受け取った文字列： " + request.downloadHandler.text);

		// リクエスト送信
		yield return request.SendWebRequest();

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