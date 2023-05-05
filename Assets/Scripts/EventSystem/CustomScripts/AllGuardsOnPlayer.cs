using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllGuardsOnPlayer : MonoBehaviour
{

    public GameObject player;
    UnityEngine.AI.NavMeshAgent agent;
    public Transform target;
    public List<GameObject> guards = new List<GameObject>();
    bool gloryRunTime = false;

    void Start()
    {
        guards = this.GetComponent<EnemyManager>().enemyList;
        target = GameObject.FindGameObjectWithTag("PlayerBody").transform;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (gloryRunTime)
        {
            foreach (GameObject guard in guards)
            {
                guard.GetComponent<NavmeshAgentScript>().lastSeenAt = target.transform.position;
            }
        }
    }

    public void TargetPlayer()
    {
        //this.GetComponent<NavmeshAgentScript>().lastSeenAt = target;
        foreach (GameObject guard in guards)
        {
            guard.GetComponent<NavmeshAgentScript>().AIState = 1;
        }
        gloryRunTime = true;
        
    }
}
