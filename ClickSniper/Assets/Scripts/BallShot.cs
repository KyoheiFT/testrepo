using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShot : MonoBehaviour
{
    public GameObject prefab;//�{�[����prefab�f�[�^������
    public float power;//�{�[���ɉ������
    private float time;//�A�˖h�~
    // Start is called before the first frame update
    void Start()
    {
        time = 0.3f;//�^�C�����P�b�Ŏn�߂āA�ŏ��̂P��͔���OK
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;//�A�˖h�~�@�J�E���g�A�b�v�^�C�}�[
        if (time >= 0.3f)//�A�˖h�~�P�b���ĂΎ��s
        {
            if (Input.GetMouseButtonDown(0))//�}�E�X���N���b�N�����Ƃ�
            {
                //prefab�̃{�[���𐶐�
                GameObject ball = GameObject.Instantiate(prefab) as GameObject;
                //�{�[���̔��ˈʒu��Controller�̈ʒu�ɂ���
                ball.transform.position = this.transform.position;
                //�}�E�X�N���b�N�����ʒu��Ray���΂�
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                //ray�̕������擾���Atarget�Ɋi�[
                Vector3 target = ray.direction;
                //�N���b�N�����Ƃ���Ɍ����āA�{�[���ɉ����x������
                ball.GetComponent<Rigidbody>().velocity = target * power;
                time = 0.0f; //�A�˖h�~�^�C�}�[��0�ɖ߂�
            }
        }
    }
}
