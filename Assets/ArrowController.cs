using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;

    //矢の落下速度
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

        //当たり判定
        Vector2 p1 = transform.position;                //矢の中心座標
        Vector2 p2 = this.player.transform.position;    //プレイヤーの中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        //矢がプレイヤーに当たった時
        if(d < r1 + r2)
        {
            //監督スクリプトにプレイやと衝突したことを伝える
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();

            //パーティクルシステムを再生
            this.player.GetComponent<ParticleSystem>().Play();

            //衝突した矢は消す
            Destroy(gameObject);
        }
    }

}
