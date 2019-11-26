using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgm : MonoBehaviour
{
    AudioSource a1;
    public AudioClip[] BGM;
    public static bgm ins;
    // Use this for initialization
    void Start()
    {
        a1 = GetComponent<AudioSource>();
        ins = this;
    }
    public static void Play(int no)
    {
        ins.a1.clip = ins.BGM[no];
        ins.a1.Play();
    }
    public static void Stop()
    {
        ins.a1.Stop();
    }
    public void sev(float v)
    {
        ins.a1.volume = v;
    }
}
