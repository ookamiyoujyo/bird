using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public TextMeshProUGUI ui;
    public TextMeshProUGUI lv;
    public GameObject my;

    int sukoa = 100,level = 2;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        bgm.Play(0);
    }
    // Start is called before the first frame update
    void Update()
    {
        if (sukoa >= 500)
        {
            if (level == 2)
            {
                lv.GetComponentInChildren<TextMeshProUGUI>().text = level + "";
                my.GetComponent<control>().level2();
                level++;
            }
        }

        if (sukoa >= 1000)
        {
            if (level == 3)
            {
                lv.GetComponentInChildren<TextMeshProUGUI>().text = level + "";
                my.GetComponent<jump>().level3();
                level++;
            }
        }

        if (sukoa >= 3000)
        {
            if (level == 4)
            {
                bgm.Stop();
                bgm.Play(1);
                lv.GetComponentInChildren<TextMeshProUGUI>().text = level + "";
                my.GetComponent<jump>().level4();
                level++;
            }
        }

        if (sukoa >= 5000)
        {
            if (level == 5)
            {
                lv.GetComponentInChildren<TextMeshProUGUI>().text = level + "";
                my.GetComponent<control>().level5();
                level++;
            }
        }

        if (sukoa >= 7500)
        {
            if (level == 6)
            {
                lv.GetComponentInChildren<TextMeshProUGUI>().text = level + "";
                my.GetComponent<jump>().level6();
                level++;
            }
        }

        if (sukoa >= 10000)
        {
            if (level == 7)
            {
                bgm.Stop();
                bgm.Play(2);
                lv.text = "MAX";
                my.GetComponent<jump>().level7();
                level++;
            }
        }
    }


    public void apple()
    {
        sukoa += 1000;
        ui.GetComponentInChildren<TextMeshProUGUI>().text = sukoa + "";
    }
    public void cherry()
    {
        sukoa += 500;
        ui.GetComponentInChildren<TextMeshProUGUI>().text = sukoa + "";
    }
    public void acorn()
    {
        sukoa += 100;
        ui.GetComponentInChildren<TextMeshProUGUI>().text = sukoa + "";
    }
    public void ran()
    {
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(sukoa);
    }
}
