using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cherry : MonoBehaviour
{
    public GameObject gamemane;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            gamemane.GetComponent<score>().cherry();
            gamemane.GetComponent<life>().get();
            Destroy(gameObject);
        }
    }
}
