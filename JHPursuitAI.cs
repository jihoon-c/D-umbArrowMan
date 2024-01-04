using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;



public class JHPursuitAI : MonoBehaviour

{
    public enum CurrentState { idle, trace, shot, dead };
    public CurrentState curState = CurrentState.idle;

    private Transform _transform;
    private Transform playerTransform;
    private NavMeshAgent nvAgent;
    private Animator _animator;

    //trace range
    public float traceDist = 300.0f;
    //attack range
    public float attackDist = 3.2f;

    //isDead
    private bool isDead = false;
    void Start()

    {
        _transform = this.gameObject.GetComponent<Transform>();
        playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
        nvAgent = this.gameObject.GetComponent<NavMeshAgent>();
        _animator = this.gameObject.GetComponent<Animator>();

        //nvAgent.destination = playerTransform.position;

        StartCoroutine(this.CheckState());
        StartCoroutine(this.CheckStateForAction());

    }

    IEnumerator CheckState()
    {
        while (!isDead)
        {
            yield return new WaitForSeconds(0.2f);
            float dist = Vector3.Distance(playerTransform.position, _transform.position);
    
            if (dist <= attackDist)
            {
                curState = CurrentState.shot;
            }

            else if (dist <= traceDist)
            {
                curState = CurrentState.trace;
            }

            else
            {
                curState = CurrentState.idle;
            }
        }
    }



    IEnumerator CheckStateForAction()
    {
        while (!isDead)
        {
            switch (curState)
            {
                case CurrentState.idle:
                    nvAgent.Stop();
                    _animator.SetBool("isTrace", false);
                    break;
                case CurrentState.trace:
                    nvAgent.destination = playerTransform.position;
                    nvAgent.Resume();
                    _animator.SetBool("isTrace", true);
                    break;
                case CurrentState.shot:
                    break;
            }
            yield return null;
        }
    }
    // Update is called once per frame
    void Update()

    {

    }
}