using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallShake : MonoBehaviour
{
    public GameObject go2;
    int num2 = 0;
    private AudioSource theAudio; //���������

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
            AudioSource audioSource = gameObject.AddComponent<AudioSource>();//�����
            theAudio.Play();
            num2++;
        }
    }
}
