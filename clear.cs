using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class clear : MonoBehaviour
{
    public GameObject gm;
    int a = 0;
   public void cleardesu()
    {
      gm.GetComponent<score>().ran();
    }
    public void overdesu()
    {
        SceneManager.LoadScene("title");
    }
}
