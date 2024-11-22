using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Playerのオブジェクトを定義
    public float playerSpeed = 0.2f;
    private float movableRange = 8.0f;
    private bool isLButtonDown = false;
    private bool isRButtonDown = false;



    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void LButtonDown()
    {
        this.isLButtonDown = true;
    }

    public void LButtonUp()
    {
        this.isLButtonDown = false;
    }


    public void RButtonDown()
    {
        this.isRButtonDown = true;
    }

    public void RButtonUp()
    {
        this.isRButtonDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.RightArrow) || this.isRButtonDown) && transform.position.x <= this.movableRange)
        {
            transform.Translate(this.playerSpeed, 0, 0);
        }
        else if((Input.GetKey(KeyCode.LeftArrow) || this.isLButtonDown) && transform.position.x >= - this.movableRange)
        {
            transform.Translate(-this.playerSpeed, 0, 0);
        }
    }
}
