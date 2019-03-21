using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    int flag1 = 0, flag2 = 0, flag3 = 0, flag4 = 0;
    public GameObject my;
    float speed = 0.5f,speed1;
    // Update is called once per frame
    void Start()
    {
        speed1 = speed;
    }
    void Update()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        if (Input.GetKey("w"))
        {
            my.GetComponent<animation>().hop();
            this.transform.Translate(this.transform.forward * Time.deltaTime * speed, Space.World);
            flag1 = 1;
        }
        else
        {
            if (flag1 == 1)
            {
                my.GetComponent<animation>().nohop();
                flag1 = 0;
            }
        }
        if (Input.GetKey("s"))
        {
            my.GetComponent<animation>().hop();
            this.transform.Translate(this.transform.forward * Time.deltaTime * -speed, Space.World);
            flag2 = 1;
        }
        else
        {
            if (flag2== 1)
            {
                my.GetComponent<animation>().nohop();
                flag2 = 0;
            }
        }
        if (Input.GetKey("a"))
        {
            my.GetComponent<animation>().hop();
            this.transform.Translate(this.transform.right * Time.deltaTime * -speed, Space.World);
            flag3 = 1;
        }
        else
        {
            if (flag3 == 1)
            {
                my.GetComponent<animation>().nohop();
                flag3 = 0;
            }
        }
        if (Input.GetKey("d"))
        {
            my.GetComponent<animation>().hop();
            this.transform.Translate(this.transform.right * Time.deltaTime * speed, Space.World);
            flag4 = 1;
        }
        else
        {
            if (flag4 == 1)
            {
                my.GetComponent<animation>().nohop();
                flag4 = 0;
            }
        }
    }
    public void fly()
    {
        speed = 5.0f;
    }
    public void Jump()
    {
        speed = 3.0f;
    }
    public void walk()
    {
        speed = speed1;
    }
    public void level2()
    {
        speed = 1.5f;
        speed1 = speed;
    }
    public void level5()
    {
        speed = 2.5f;
        speed1 = speed;
    }
}
