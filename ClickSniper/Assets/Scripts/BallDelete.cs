using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDelete : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //Y���W-10�܂ŗ��������Ƃ�
        if(transform.position.y <= -10f)
        {
            //�I�u�W�F�N�g���폜����
            Destroy(gameObject);
        }
    }
}
