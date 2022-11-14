using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Animator anim;
    public float speed = 5f;
    private Rigidbody characterRigidbody;
    float inputX;
    float inputZ;
    Vector3 moveVec;
    
    private void Awake()
    {
        characterRigidbody = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        GetInput();
        Moving();
        Turn();
    }
    
    void Turn()
    {
        transform.LookAt(transform.position + moveVec);
    }
    void GetInput()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");

    }
    void Moving()
    {
        moveVec = new Vector3(inputX, 0, inputZ).normalized;
        transform.position += moveVec *speed*Time.deltaTime;
        anim.SetBool("Run", moveVec != Vector3.zero);
    }
}
