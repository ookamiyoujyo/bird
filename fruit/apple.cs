using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple : MonoBehaviour
{
    public GameObject gamemane;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            gamemane.GetComponent<score>().apple();
            gamemane.GetComponent<life>().get();
            Destroy(gameObject);
        }
    }
}
