using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class gameover : MonoBehaviour
{
	float fadeSpeed = 0.01f;        //透明度が変わるスピードを管理
    float red, green, blue, alfa;   //パネルの色、不透明度を管理
    float red1, green1, blue1, alfa1;

    public bool isFadeOut = false;  //フェードアウト処理の開始、完了を管理するフラグ
    public bool isFadeIn = false;   //フェードイン処理の開始、完了を管理するフラグ

    public Image fadeImage;                //透明度を変更するパネルのイメージ
    public TextMeshProUGUI Gtext;

    public GameObject bata;
    int end = 0;
    void Start()
    {
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;

        red1 = Gtext.color.r;
        green1 = Gtext.color.g;
        blue1 = Gtext.color.b;
        alfa1 = Gtext.color.a;
    }

    void Update()
    {
        if (end == 1)
        {
            StartFadeOut();
        }
    }

    void StartFadeOut()
    {
        fadeImage.enabled = true;  // a)パネルの表示をオンにする
        alfa1 += fadeSpeed;
        alfa += fadeSpeed;         // b)不透明度を徐々にあげる
        SetAlpha();               // c)変更した透明度をパネルに反映する
        if (alfa >= 1)
        {             // d)完全に不透明になったら処理を抜ける
            bata.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
        Gtext.color = new Color(red1, green1, blue1, alfa1);
    }

    public void endflag()
    {
        end = 1;
    }
}

