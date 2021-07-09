using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject target;//プレハブを入れるための変数
    private float time;//出現の間隔時間
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;//カウントダウンタイマー
        //timeが0秒になったら
        if(time <= 0.0f)
        {
            //プレハブを出現させる
            Instantiate(target,new Vector3(-40, 5, 30), Quaternion.identity);
            time = 5.0f;//5秒に戻す
        }
    }
}
