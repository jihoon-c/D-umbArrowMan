using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buddhaS : MonoBehaviour
{
    public GameObject[] dwalls;
    GameObject obj;
    GameObject rai;
    void Start()
    {
        obj = GameObject.Find("MainCamera");
        rai = GameObject.Find("Laser Toon StarBlaster");
        //obj.GetComponent<JHCAMshake>().OnShakeCamera();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            dwalls = GameObject.FindGameObjectsWithTag("Dwall");
            for (int i = 0; i < 180; i++)
            {
                Destroy(dwalls[i], 2);
            }
            //rai.GetComponent<RaserShot>().Shooot(); // �״� �浹�� ������ �߻� ��ũ��Ʈ ����
        }
        /*if (collision.gameObject.tag == "Player")
        {
            obj.GetComponent<JHCAMshake>().OnShakeCamera();
        }*/
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // ���� Ȱ��ȭ
        }
    }
}
