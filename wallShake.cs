using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallShake : MonoBehaviour
{
    public GameObject go2;
    int num2 = 0;
    private AudioSource theAudio; //음원재생기

    void Start()
    {
        theAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        SoundPlay2();
    }
    private void SoundPlay2()
    {
        if (go2.GetComponent<BuddhaPattern>().isTouch == true && num2 == 0)
        {
            AudioSource audioSource = gameObject.AddComponent<AudioSource>();//오디오
            theAudio.Play();
            num2++;
        }
    }
}
