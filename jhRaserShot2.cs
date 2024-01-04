using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jhRaserShot2 : MonoBehaviour
{
    public GameObject target2;
    float speed = 5f;


    void Start()
    {
        GameObject target2 = GameObject.Find("Player");
    }

    void Update()
    {
        PursuitLay();
    }
    public void PursuitLay()
    {
        if (target2 != null)// 플레이어 천천히 따라가는 레이저
        {
            Vector3 dir = target2.transform.position - this.transform.position;
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * speed);
        }
    }
    void OnParticleCollision(GameObject other)
    {
           Destroy(target2);  
    }
}
