using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NPCmotion : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject target;


    // Start is called before the first frame update
    void Start()
    {
        agent=GetComponent<NavMeshAgent>();
        agent.enabled = true;  
    }

    // Update is called once per frame
    void Update()
    {
        //sets target and starts moving to the target
       /// if(agent.enabled)
       // agent.SetDestination(target.transform.position);

    }
}
