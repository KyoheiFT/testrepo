using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove : MonoBehaviour
{
    //�^�[�Q�b�g�̈ړ��X�s�[�h
    [SerializeField] float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //X�����ֈړ�
        transform.position += new Vector3(Time.deltaTime * speed, 0, 0);
        //X���W��60�𒴂���΁A�^�[�Q�b�g���폜����
        if(transform.position.x >= 60f)
        {
            Destroy(gameObject);
        }
    }
}
