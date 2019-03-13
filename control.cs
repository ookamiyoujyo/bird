using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    [SerializeField] public float speed = 2.0f;
    int jumprock = 1;
    public Rigidbody rb;
    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;
        rb.AddForce(x, 0, z);
    }
}
