using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//テキストを扱う場合に必要

public class ScoreCount : MonoBehaviour
{
    public int score = 0;//スコアを入れる変数
    public Text ScoreText;//表示するテキスト

    // Update is called once per frame
    void Update()
    {
        //scoreのデータをテキスト形式に変換。スコアテキストを表示する
        ScoreText.text = "SCORE:" + score.ToString();
    }
    //オブジェクトがぶつかった時の処理
    public void OnCollisionEnter(Collision collision)
    {
        //ぶつかった相手にScorePointタグがついているとき
        if (collision.gameObject.CompareTag("ScorePoint"))
        {
            Destroy(collision.gameObject);//オブジェクトを消す
            score++;//scoreを1増やす
        }
        //ぶつかった相手にDeleteタグがついているとき
        if (collision.gameObject.CompareTag("Delete"))
        {
            Destroy(collision.gameObject);//オブジェクトを消す
        }
    }
}
