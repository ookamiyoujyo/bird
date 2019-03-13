using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public Rigidbody rb;
    public float JumpPower;
    int jumprock = 0,rock = 10;
    

    void Update()
    {
        if (jumprock > 0)
        {
            if (Input.GetButtonDown("Jump"))
            {
                jumprock -= 1;
                rb.velocity = transform.up * JumpPower;
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
    void OnCollisionStay(Collision other)
    {
        //ジャンプ制限
        if (other.gameObject.tag == "grand")
        {
            jumprock = rock;
        }
    }
   
}
