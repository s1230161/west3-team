using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yajiScript : MonoBehaviour {

    GameObject hero;
    GameObject pref_yaji;
    private Vector3 startP, endP;
    GameObject yajiC;

    // Use this for initialization
    void Start () {

        hero = GameObject.Find("Hero");
        pref_yaji = (GameObject)Resources.Load("Prefabs/yaji");
        pref_yaji.transform.localScale = new Vector3(0, 0, 0);
		
	}
	
	// Update is called once per frame
	void Update () {
        //主人公の速度が０だったら
        if(hero.GetComponent<Rigidbody2D>().velocity.magnitude == 0)
        {
            //マウスボタンを押したとき
            if (Input.GetMouseButtonDown(0))
            {
                startP = Input.mousePosition;
                Instantiate(pref_yaji, hero.transform.position, Quaternion.identity);
                yajiC = GameObject.Find("yaji(Clone)");
            }
            //マウスボタンを押している間
            if (Input.GetMouseButton(0) && GameObject.Find("yaji(Clone)") != null)
            {
                endP = Input.mousePosition;
                float dx = endP.x - startP.x;
                float dy = endP.y - startP.y;
                float distance = Mathf.Sqrt(dx * dx + dy * dy);
                yajiC.transform.localScale = new Vector3(distance / 170f, distance / 500f, 1);


                float rad = Mathf.Atan2(dy, dx);
                float dir = rad * Mathf.Rad2Deg;
                yajiC.transform.rotation = Quaternion.Euler(0.0f, 0.0f, dir);
            }
            //マウスボタンを離したとき
            if (Input.GetMouseButtonUp(0))
                DestroyObject(GameObject.Find("yaji(Clone)"));
        }

    }
}
