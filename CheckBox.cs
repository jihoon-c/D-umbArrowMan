using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBox : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject miniPrefab;
    public GameObject box;
    int miniSpawnLimit;

    void Start()
    {
       
    }

    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            for (int i = 0; i < 5; ++i)//count 수 만큼 생성한다
            {
                SpawnMini(miniPrefab, new Vector3(i+(5*i), 0, 20));
            }
        }
    }

    public GameObject[] miniPrefabs;

    public void SpawnMini(GameObject prefab,Vector3 _position)
    {
        if (enableSpawn)
        {
            miniPrefabs = GameObject.FindGameObjectsWithTag("Mini");
            if (miniPrefabs.Length < 6)
            {
               GameObject mini = Instantiate(prefab);
               mini.transform.position = _position;
            }
            else Destroy(box);
        }  
    }


}
