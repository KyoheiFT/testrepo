using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] targetArray;//プレハブを入れるための変数配列
    private int count;//出現数のカウント
    private float time;//出現の間隔時間
    private int vecY;//_Y座標を入れる変数
    // Start is called before the first frame update
    void Start()
    {
        count = 0;//countの初期値
    }
    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;//カウントダウンタイマー
        //timeが0秒になったら
        if(time <= 0.0f)
        {
            vecY = Random.Range(0, 20);//0～12で値をランダム生成
            //登録したターゲットを順番に生成。Y座標をvecYとする
            Instantiate(targetArray[count],new Vector3(-40, vecY, 30), Quaternion.identity);
            time = 5.0f;//5秒に戻す
            if(count <= 1)
            {
                count++;//カウントを１増やす
            }
            else if(count == 2)
            {
                count = 0;//カウントを０に戻す
            }
            
        }
    }
}
