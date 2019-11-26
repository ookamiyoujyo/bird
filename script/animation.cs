using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    private Animator animator;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void hop()
    {
        animator.SetFloat("HOP", 0.1f);
    }
    public void nohop()
    {
        animator.SetFloat("HOP", 0f);
    }
    public void fry()
    {
        Debug.Log("fry");
        animator.SetFloat("fry", 0.1f);
    }
    public void nofry()
    {
        animator.SetFloat("fry", 0f);
    }
    public void eat()
    {
        animator.SetTrigger("eat");
        animator.SetTrigger("eat");
    }
    public void gameover()
    {
        animator.SetTrigger("over");
    }
}
