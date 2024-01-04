using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniDestroy1 : MonoBehaviour
{
    public GameObject[] minii;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        minii = GameObject.FindGameObjectsWithTag("Mini"); // 미니 삭제
        for (int i = 0; i < 10; i++)
        {
            Destroy(minii[i]);
        }
    }
}
