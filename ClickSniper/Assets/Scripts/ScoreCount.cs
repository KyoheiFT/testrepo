using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//�e�L�X�g�������ꍇ�ɕK�v

public class ScoreCount : MonoBehaviour
{
    public int score = 0;//�X�R�A������ϐ�
    public Text ScoreText;//�\������e�L�X�g

    // Update is called once per frame
    void Update()
    {
        //score�̃f�[�^���e�L�X�g�`���ɕϊ��B�X�R�A�e�L�X�g��\������
        ScoreText.text = "SCORE:" + score.ToString();
    }
    //�I�u�W�F�N�g���Ԃ��������̏���
    public void OnCollisionEnter(Collision collision)
    {
        //�Ԃ����������ScorePoint�^�O�����Ă���Ƃ�
        if (collision.gameObject.CompareTag("ScorePoint"))
        {
            Destroy(collision.gameObject);//�I�u�W�F�N�g������
            score++;//score��1���₷
        }
        //�Ԃ����������Delete�^�O�����Ă���Ƃ�
        if (collision.gameObject.CompareTag("Delete"))
        {
            Destroy(collision.gameObject);//�I�u�W�F�N�g������
        }
    }
}
