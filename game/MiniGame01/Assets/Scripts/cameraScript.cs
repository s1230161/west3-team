using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour
{
    // ズレを保存するインスタンスメンバ
    Vector3 startOffset;

    void Start()
    {
        // 主人公のゲームオブジェクトを取得
        GameObject hero = GameObject.Find("Hero");

        // ゲームがスタートした時の主人公の座標をheroPosに代入
        Vector3 heroPos = hero.transform.position;

        // ゲームがスタートした時のカメラの座標をcameraPosに代入
        Vector3 cameraPos = this.transform.position;

        // カメラと主人公の座標のズレをstartOffsetに記憶
        startOffset = (cameraPos - heroPos);
    }

    void LateUpdate()
    {
        // 主人公のゲームオブジェクトを取得
        GameObject hero = GameObject.Find("Hero");

        // 主人公の生存確認
        if (null == hero)
        {
            return;
        }

        // 現在の主人公の座標をheroPosに代入
        Vector3 heroPos = hero.transform.position;

        // 現在のカメラの座標をcameraPosに代入
        Vector3 cameraPos = this.transform.position;

        // heroPosのx座標＋startOffsetでcameraPosのx座標を上書き
        cameraPos.y = heroPos.y + startOffset.y;

        // カメラの座標にcameraPosを戻す
        this.transform.position = cameraPos;
    }

}
