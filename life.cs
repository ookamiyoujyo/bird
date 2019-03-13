using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class life : MonoBehaviour
{
    private float timeleft;
    Slider slider;
    void Start()
    {
        // スライダーを取得する
        slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    float hp = 1000;
    void Update()
    {
        timeleft -= Time.deltaTime;
        if (timeleft <= 0.0)
        {
            timeleft = 0.01f;
            // HP減少
            hp -= 1f;
            if (hp < 0)
            {
                // 最大を超えたら0に戻す
                hp = 0;
            }
        }
        // HPゲージに値を設定
        slider.value = hp;
    }
}
