using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniDestroy : MonoBehaviour
{
    public GameObject[] minii;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            minii = GameObject.FindGameObjectsWithTag("Mini");
            for (int i = 0; i < 10; i++)
            {
                Destroy(minii[i]);
            }
        }
    }
}
