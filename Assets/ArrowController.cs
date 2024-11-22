using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;

    //��̗������x
    private float arrowSpeed = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, - this.arrowSpeed, 0);

        if(transform.position.y<-5.0f)
        {
            Destroy(gameObject);
        }

        //�����蔻��
        Vector2 p1 = transform.position;                //��̒��S���W
        Vector2 p2 = this.player.transform.position;    //�v���C���[�̒��S���W
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        //��v���C���[�ɓ���������
        if(d < r1 + r2)
        {
            //�ēX�N���v�g�Ƀv���C��ƏՓ˂������Ƃ�`����
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();

            //�p�[�e�B�N���V�X�e�����Đ�
            this.player.GetComponent<ParticleSystem>().Play();

            //�Փ˂�����͏���
            Destroy(gameObject);
        }
    }

}
