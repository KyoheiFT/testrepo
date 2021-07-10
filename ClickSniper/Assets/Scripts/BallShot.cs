using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShot : MonoBehaviour
{
    public GameObject prefab;//ボールのprefabデータを入れる
    public float power;//ボールに加える力
    private float time;//連射防止
    // Start is called before the first frame update
    void Start()
    {
        time = 0.3f;//タイムを１秒で始めて、最初の１回は発射OK
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;//連射防止　カウントアップタイマー
        if (time >= 0.3f)//連射防止１秒立てば実行
        {
            if (Input.GetMouseButtonDown(0))//マウス左クリックしたとき
            {
                //prefabのボールを生成
                GameObject ball = GameObject.Instantiate(prefab) as GameObject;
                //ボールの発射位置をControllerの位置にする
                ball.transform.position = this.transform.position;
                //マウスクリックした位置にRayを飛ばす
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                //rayの方向を取得し、targetに格納
                Vector3 target = ray.direction;
                //クリックしたところに向けて、ボールに加速度をつける
                ball.GetComponent<Rigidbody>().velocity = target * power;
                time = 0.0f; //連射防止タイマーを0に戻す
            }
        }
    }
}
