using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] targetArray;//�v���n�u�����邽�߂̕ϐ��z��
    private int count;//�o�����̃J�E���g
    private float time;//�o���̊Ԋu����
    private int vecY;//_Y���W������ϐ�
    // Start is called before the first frame update
    void Start()
    {
        count = 0;//count�̏����l
    }
    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;//�J�E���g�_�E���^�C�}�[
        //time��0�b�ɂȂ�����
        if(time <= 0.0f)
        {
            vecY = Random.Range(0, 20);//0�`12�Œl�������_������
            //�o�^�����^�[�Q�b�g�����Ԃɐ����BY���W��vecY�Ƃ���
            Instantiate(targetArray[count],new Vector3(-40, vecY, 30), Quaternion.identity);
            time = 5.0f;//5�b�ɖ߂�
            if(count <= 1)
            {
                count++;//�J�E���g���P���₷
            }
            else if(count == 2)
            {
                count = 0;//�J�E���g���O�ɖ߂�
            }
            
        }
    }
}
