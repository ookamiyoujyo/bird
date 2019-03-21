using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class life : MonoBehaviour
{
    private float timeleft;
    private Slider slider;
    public GameObject my;
    public GameObject gamemanager;
    void Start()
    {
        // スライダーを取得する
        slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    float hp = 1000;
    float power = 1f;
    void Update()
    {
        timeleft -= Time.deltaTime;
        if (timeleft <= 0.0)
        {
            timeleft = 0.01f;
            // HP減少
            hp -= power;
            if (hp < 0)
            {
                gamemanager.GetComponent<gameover>().endflag();
                my.GetComponent<animation>().gameover();
                hp = 0;
            }
        }
        // HPゲージに値を設定
        slider.value = hp;
    }
    public void get()
    {
        my.GetComponent<animation>().eat();
        hp = 1000;
    }

    public void dei()
    {
        power = 0;
    }
    public void sta()
    {
        Debug.Log("9");
            power = 1f;
      
    }
}
