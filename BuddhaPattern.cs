using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class BuddhaPattern : MonoBehaviour

{
    public GameObject pan;
    public GameObject[] dwalls;
    
    private Transform _transform;
    private Transform playerTransform;
    public GameObject maincam;
    public GameObject monk;
    public Transform target;
    public GameObject raser;
    public GameObject raser2;
    public Transform kneelingPort;
    public GameObject player;
    public GameObject bom;
    public GameObject bom2;
    public Transform buddhaTrans;
    public bool isTouch = false;
    bool isMessage = false;
    public bool isDead = false;

 
    private int i = 0;
   
    void Start()
    {
        _transform = this.gameObject.GetComponent<Transform>();
        playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();

        
    }

    void OnCollisionEnter(Collision collision) //Ãæµ¹½Ã º® ÆÄ±«
    {
        if (collision.gameObject.tag == "Player")
        {
            Doing();
            
        }
        if (collision.gameObject.tag == "Arrow"&& isTouch==true)
        {
            Die();
        }

    }

    IEnumerator BuddhaAttack()
    {
        yield return new WaitForSeconds(0.1f);

        int ranAction = Random.Range(0, 2);
        switch (ranAction)
        {
            case 0:
                StartCoroutine(LayAll());
                break;
            case 1:
                StartCoroutine(LayTrace());
                break;

        }
    }

    
    IEnumerator LayAll()
    {
        yield return new WaitForSeconds(2f);

        GameObject instantRaser = Instantiate(raser, kneelingPort.position, kneelingPort.rotation);
        jhRaserShot1 bossRaser = instantRaser.GetComponent<jhRaserShot1>();
       // bossRaser.target1 = target;

        yield return new WaitForSeconds(5f);

        Destroy(instantRaser);

        StartCoroutine(BuddhaAttack());

    }

    IEnumerator LayTrace()
    {
       
        yield return new WaitForSeconds(2f);
        GameObject instantRaser = Instantiate(raser2);
        jhRaserShot2 bossRaser = instantRaser.GetComponent<jhRaserShot2>();
        bossRaser.target2 = player;

        yield return new WaitForSeconds(5f);
        Destroy(instantRaser);

        StartCoroutine( BuddhaAttack());

    }

    public void Doing()
    {
        isTouch = true;

        maincam.GetComponent<JHCAMshake>().enabled = true; //Ä· Èçµé±â

        dwalls = GameObject.FindGameObjectsWithTag("Dwall"); // º®ÆÄ±«
        for (int i = 0; i < 200; i++)
        {
            Destroy(dwalls[i], 2.3f);
            Destroy(monk);
        }

       

    }

    void StartCo()
    {
        StartCoroutine(BuddhaAttack());
    }
 
    void Message()
    {
        GameObject.Find("GameManager").transform.Find("panel").gameObject.SetActive(true); //µµ¸Á ¸Þ½ÃÁö Ãâ·Â
        isMessage = true;
       
    }

    void DestroyMessage()
    {
        GameObject.Find("GameManager").transform.Find("panel").gameObject.SetActive(false); //µµ¸Á ¸Þ½ÃÁö »èÁ¦
    }

    private void Die()
    {
        isDead = true;
        StopCoroutine(BuddhaAttack());
        Destroy(raser);
        Debug.Log("º¸½º°¡ »ç¸ÁÇß½À´Ï´Ù");
        Invoke("boomer", 1f);
        Destroy(gameObject,1f);
        GameObject.Find("JHLaser2(Clone)").gameObject.SetActive(false);
        GameObject.Find("JHLaser(Clone)").gameObject.SetActive(false);


    }
    public void boomer()
    {
        GameObject Boom = Instantiate(bom, buddhaTrans.position, buddhaTrans.rotation);
        GameObject Boom2 = Instantiate(bom2, buddhaTrans.position, buddhaTrans.rotation);
    }

    

    void Update()
    {
        if (isTouch == true && isMessage == false)
        {
            Message();
            Invoke("DestroyMessage", 2f);
        }

        if(isTouch == true)
        {
            if (i < 1)
            {
               
                StartCoroutine(BuddhaAttack());
                i++;

            }
        }
       
    }
}