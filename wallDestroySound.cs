using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class wallDestroySound : MonoBehaviour
{
    public GameObject go;
    int num = 0;
    private AudioSource theAudio; //음원재생기

    void Start()
    {
        theAudio = GetComponent<AudioSource>();
        
    }

    void Update()
    {
        Invoke("SoundPlay", 8.3f); // 보스 부서질 때 같이 호출됨
    }

    private void SoundPlay()
    {
        if (go.GetComponent<BuddhaPattern>().isDead == true && num == 0)
        {
            AudioSource audioSource = gameObject.AddComponent<AudioSource>();//오디오
            theAudio.Play();
            num++;
            GameObject.Find("JHLaser2(Clone)").gameObject.SetActive(false);
            GameObject.Find("JHLaser(Clone)").gameObject.SetActive(false);
        }
    }
}
