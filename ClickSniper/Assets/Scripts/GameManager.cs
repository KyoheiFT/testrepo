using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject target;//�v���n�u�����邽�߂̕ϐ�
    private float time;//�o���̊Ԋu����
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;//�J�E���g�_�E���^�C�}�[
        //time��0�b�ɂȂ�����
        if(time <= 0.0f)
        {
            //�v���n�u���o��������
            Instantiate(target,new Vector3(-40, 5, 30), Quaternion.identity);
            time = 5.0f;//5�b�ɖ߂�
        }
    }
}
