using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI�������ۂɕK�v
using UnityEngine.SceneManagement;//�V�[�������[�h����ۂɕK�v

public class GameManager : MonoBehaviour
{
    public GameObject[] targetArray;//�v���n�u�����邽�߂̕ϐ��z��
    private int count;//�o�����̃J�E���g
    private int fin;//�Q�[���I���̔��f
    private float time;//�o���̊Ԋu����
    private int vecY;//_Y���W������ϐ�
    public Text timeUP;//�e�L�X�g�����邽�߂̕ϐ�
    private float lastTime = 8.0f;//�Ō�̃^�[�Q�b�g��������܂ł̎��Ԃ��W�b��
    public GameObject retryButton;//���g���C�{�^��������ϐ�
    // Start is called before the first frame update
    void Start()
    {
        count = 0;//count�̏����l
        fin = 0;//fin�̏����l
        retryButton.SetActive(false);//���g���C�{�^�����\��
    }
    // Update is called once per frame
    void Update()
    {
        //�u�o�����������^�[�Q�b�g�̓o�^���ł���Ύ��s
        if (fin == targetArray.Length)
        {
            lastTime -= Time.deltaTime;//8�b����J�E���g�_�E��
            //lastTime��0�ɂȂ����Ƃ�
            if (lastTime <= 0)
            {
                timeUP.text = "TIME UP";//TIME UP��\������
                GetComponent<BallShot>().enabled = false;//BallShot.cs�𖳌��ɂ���
                retryButton.SetActive(true);//���g���C�{�^����\��
            }
        }
        else//�u�o�����������^�[�Q�b�g�̓o�^���v�łȂ���Ύ��s
        {
            time -= Time.deltaTime;//�J�E���g�_�E���^�C�}�[
            //time��0�b�ɂȂ�����
            if (time <= 0.0f)
            {
                vecY = Random.Range(0, 20);//0�`12�Œl�������_������
                                           //�o�^�����^�[�Q�b�g�����Ԃɐ����BY���W��vecY�Ƃ���
                Instantiate(targetArray[count], new Vector3(-40, vecY, 30), Quaternion.identity);
                time = 5.0f;//5�b�ɖ߂�
                if (count <= 1)
                {
                    count++;//�J�E���g���P���₷
                }
                else if (count == 2)
                {
                    count = 0;//�J�E���g���O�ɖ߂�
                    fin = 3;//�^�C���A�b�v�����ON�ɂ���
                }
            }
            
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
