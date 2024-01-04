using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JHPortal : MonoBehaviour
{
    public GameObject boss;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (boss.GetComponent<BuddhaPattern>().isDead == true)
        {
            GameObject.Find("Portal").transform.Find("portal").gameObject.SetActive(true);
        }
        

       
    }
}
