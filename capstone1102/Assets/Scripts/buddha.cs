using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buddha : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(GameObject.FindGameObjectWithTag("Dwall")); //부서질 벽을 삭제
        }
    }
}
