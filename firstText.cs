using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstText : MonoBehaviour
{
    public GameObject panel1;
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(go), 3f);
        Destroy(panel1, 6f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void go()
    {
        GameObject.Find("GameManager").transform.Find("panel (1)").gameObject.SetActive(true);
    }
}
