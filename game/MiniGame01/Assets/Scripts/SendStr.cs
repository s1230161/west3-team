/*using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//public class SendStr : MonoBehaviour{

	public void ConnectionStart(){
		StartCoroutine(Connection("str"));
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
//}
*/