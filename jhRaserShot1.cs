using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jhRaserShot1 : MonoBehaviour
{
    
    float speed = 5f;
    float v;
    
    void Start()
    {
        
    }

    void Update()
    {
        RotLay();
    }

    public void RotLay()
    {

        if (-100<v&&v<500)// 회전 레이저
        {
              v += 53 * Time.deltaTime;
              transform.eulerAngles = new Vector3(0, v, 0);
        }

    }


    
  
}