using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UIを扱う際に必要
using UnityEngine.SceneManagement;//シーンをロードする際に必要

public class GameManager : MonoBehaviour
{
    public GameObject[] targetArray;//プレハブを入れるための変数配列
    private int count;//出現数のカウント
    private int fin;//ゲーム終了の判断
    private float time;//出現の間隔時間
    private int vecY;//_Y座標を入れる変数
    public Text timeUP;//テキストを入れるための変数
    private float lastTime = 8.0f;//最後のターゲットが消えるまでの時間を８秒に
    public GameObject retryButton;//リトライボタンを入れる変数
    // Start is called before the first frame update
    void Start()
    {
        count = 0;//countの初期値
        fin = 0;//finの初期値
        retryButton.SetActive(false);//リトライボタンを非表示
    }
    // Update is called once per frame
    void Update()
    {
        //「出現した数＝ターゲットの登録数であれば実行
        if (fin == targetArray.Length)
        {
            lastTime -= Time.deltaTime;//8秒からカウントダウン
            //lastTimeが0になったとき
            if (lastTime <= 0)
            {
                timeUP.text = "TIME UP";//TIME UPを表示する
                GetComponent<BallShot>().enabled = false;//BallShot.csを無効にする
                retryButton.SetActive(true);//リトライボタンを表示
            }
        }
        else//「出現した数＝ターゲットの登録数」でなければ実行
        {
            time -= Time.deltaTime;//カウントダウンタイマー
            //timeが0秒になったら
            if (time <= 0.0f)
            {
                vecY = Random.Range(0, 20);//0～12で値をランダム生成
                                           //登録したターゲットを順番に生成。Y座標をvecYとする
                Instantiate(targetArray[count], new Vector3(-40, vecY, 30), Quaternion.identity);
                time = 5.0f;//5秒に戻す
                if (count <= 1)
                {
                    count++;//カウントを１増やす
                }
                else if (count == 2)
                {
                    count = 0;//カウントを０に戻す
                    fin = 3;//タイムアップ判定をONにする
                }
            }
            
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
