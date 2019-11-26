using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{
    public GameObject gamemane;
    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            gamemane.GetComponent<life>().get();
        }
    }
}
