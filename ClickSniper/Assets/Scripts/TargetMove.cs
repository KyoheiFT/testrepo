using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove : MonoBehaviour
{
    //ターゲットの移動スピード
    [SerializeField] float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //X方向へ移動
        transform.position += new Vector3(Time.deltaTime * speed, 0, 0);
        //X座標が60を超えれば、ターゲットを削除する
        if(transform.position.x >= 60f)
        {
            Destroy(gameObject);
        }
    }
}
