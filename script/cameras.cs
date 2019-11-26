using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameras : MonoBehaviour
{
    public float spinSpeed = 0.5f;
    float distance = 10f;

    Vector3 pos = Vector3.zero;
    public Vector2 mouse = Vector2.zero;


    void Start()
    {
        mouse.x = 0.5f;
        mouse.y = -0.2f;

    }

    void Update()
    {
        mouse += new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")) * Time.deltaTime * spinSpeed;
        mouse.y = Mathf.Clamp(mouse.y, -0.05f + 0.5f, 0.3f + 0.25f);//視界角度設定

        // 球面座標系変換
        pos.x = distance * Mathf.Sin(mouse.y * Mathf.PI) * Mathf.Cos(mouse.x * Mathf.PI);
        pos.y = -distance * Mathf.Cos(mouse.y * Mathf.PI);
        pos.z = -distance * Mathf.Sin(mouse.y * Mathf.PI) * Mathf.Sin(mouse.x * Mathf.PI);

        // 座標の更新
        transform.LookAt(pos + this.transform.position);

        Quaternion quaternion = this.transform.rotation;//回転軸の取得

    }

}

