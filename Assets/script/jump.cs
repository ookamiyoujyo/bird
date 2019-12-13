using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public Rigidbody rb;
    public float JumpPower = 15;
    float JumpPower1;
    int jumprock = 0,rock = 0,flg = 0;
    public GameObject my;
    public GameObject gm;
    void Start()
    {
        JumpPower1 = JumpPower;
    }
    void Update()
    {
        if (jumprock > 0)
        {
            if (Input.GetButtonDown("Jump"))
            {
                jumprock -= 1;
                Rigidbody rb = this.transform.GetComponent<Rigidbody>();
                rb.velocity = new Vector3(0, JumpPower, 0);
                my.GetComponent<control>().Jump();
                if (flg == 1)
                {
                    my.GetComponent<control>().fly();
                    my.GetComponent<animation>().fry();
                }
                JumpPower = 50;
                flg = 1;
            }
        }
        //自由落下
        if (Input.GetKey("left shift"))
        {
            rb.drag = 1.0f;
        }
        else
        {
            rb.drag = 7;
        }
    }
    void OnCollisionEnter(Collision other)
    {
        //ジャンプ制限
        if (other.gameObject.tag == "grand")
        {
            flg = 0;
            JumpPower = JumpPower1;
            my.GetComponent<control>().walk();
            my.GetComponent<animation>().nofry();
            jumprock = rock;
        }
        if(other.gameObject.tag == "goal")
        {
            gm.GetComponent<life>().dei();
            gm.GetComponent<gameclear>().endflag();
        }
    }
    public void level3()
    {
        rock = 1;
        jumprock = rock;
    }
    public void level4()
    {
        rock = 5;
        jumprock = rock;
    }
    public void level6()
    {
        rock = 10;
        jumprock = rock;
    }
    public void level7()
    {
        rock = 1000;
        jumprock = rock;
    }

    
}
