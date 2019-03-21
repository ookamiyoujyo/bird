using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    

    float fadeSpeed = 0.02f;        //透明度が変わるスピードを管理

    float red, green, blue, alfa;   //パネルの色、不透明度を管理

    public GameObject kuro;
    public Image fadeImage;                //透明度を変更するパネルのイメージ
    int a = 0;

    void Start()
    {
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;
    }

    void Update()
    {
        if (a == 1)
        {
            StartFadeOut();
        }
    }


    void StartFadeOut()
    {
        alfa += fadeSpeed;         // b)不透明度を徐々にあげる
        SetAlpha();               // c)変更した透明度をパネルに反映する
        if (alfa >= 1)
        {             // d)完全に不透明になったら処理を抜ける
                SceneManager.LoadScene("maingame");
        }
    }

    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }
    public void gogo()
    {
        Debug.Log("9");
        kuro.SetActive(true);
        a = 1;
    }
}
