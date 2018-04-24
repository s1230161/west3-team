using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroScript : MonoBehaviour {

    public float speed;
    private Vector3 startP, endP;
    private float dx,dy;
    private bool onmouse;
    private bool doaction;

	public Text cnt;
	public static int counter = 0;
    
    // Use this for initialization
    void Start () {
        onmouse = false;
        doaction = false;
	}
	
	// Update is called once per frame
	void Update () {

        //現在の速度
        float nowSpeed = GetComponent<Rigidbody2D>().velocity.magnitude;
        //現在の速度が０だったら
        if (nowSpeed == 0)
        {
            //マウスボタンが押されたとき
            if (Input.GetMouseButtonDown(0))
            {
                //マウスの座標を取得
                startP = Input.mousePosition;
                onmouse = true;
            }
            //マウスボタンが押されている間
            if (Input.GetMouseButton(0))
            {
                endP = Input.mousePosition;
                //変化量を計算
                dx = endP.x - startP.x;
                dy = endP.y - startP.y;

                //距離が短ければ実行しないようにする
                float distance = Mathf.Sqrt(dx * dx + dy * dy);
                if (distance < 50) doaction = false;
                else doaction = true;
            }
            //マウスボタンが離されたとき
            if (Input.GetMouseButtonUp(0) && onmouse && doaction)
			{
				counter++;
				cnt.text = "経過ターン数："+counter.ToString();
                onmouse = false;
                doaction = false;
                //角度を計算
                float rad = Mathf.Atan2(dy, dx) + Mathf.PI;

                //dirの方向に力を加える
                Vector2 v;
				Vector2 m;
				m.x = dx;
				m.y = dy;
				speed = Mathf.Sqrt(m.magnitude)-5;
                v.x = Mathf.Cos(rad) * speed;
                v.y = Mathf.Sin(rad) * speed;
                GetComponent<Rigidbody2D>().velocity = v;


            }
        }else if(nowSpeed < 0.1f) GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        else if (nowSpeed < speed / 3) GetComponent<Rigidbody2D>().velocity *= 0.97f;
    }

	public static int getScore(){
		return counter;
	}

}
