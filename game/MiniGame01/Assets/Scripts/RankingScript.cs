using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class RankingScript : MonoBehaviour {

	public Text ranking;
	UnityWebRequest request;
	private string tmp_str;

	// Use this for initialization
	void Start () {
		
		ConnectionStart ();

	}

	// Update is called once per frame
	void Update () {

	}

	public void ConnectionStart(){
		StartCoroutine(Connection());
	}

	private IEnumerator Connection()
	{
		request = UnityWebRequest.Get("http://192.168.11.21:3000/game/ranking");
		request.downloadHandler = new DownloadHandlerBuffer();
		//UnityWebRequest request = UnityWebRequest.Get("http://192.168.11.21:3000/game/please");

		// リクエスト送信
		yield return request.SendWebRequest();

		ranking.text = request.downloadHandler.text;

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
