using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class wallDestroySound : MonoBehaviour
{
    public GameObject go;
    int num = 0;
    private AudioSource theAudio; //���������

    void Start()
    {
        theAudio = GetComponent<AudioSource>();
        
    }

    void Update()
    {
        Invoke("SoundPlay", 8.3f); // ���� �μ��� �� ���� ȣ���
    }

    private void SoundPlay()
    {
        if (go.GetComponent<BuddhaPattern>().isDead == true && num == 0)
        {
            AudioSource audioSource = gameObject.AddComponent<AudioSource>();//�����
            theAudio.Play();
            num++;
            GameObject.Find("JHLaser2(Clone)").gameObject.SetActive(false);
            GameObject.Find("JHLaser(Clone)").gameObject.SetActive(false);
        }
    }
}
