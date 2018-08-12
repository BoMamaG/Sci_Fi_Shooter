using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class monster : MonoBehaviour {
    public GameObject player;

    private NavMeshAgent nav;
    private string state = "idle";
    private bool alive = true;
	// Use this for initialization
	void Start () {
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        if(alive)
        {
            if(state == "idle")
            {
                Vector3 randomPos = Random.insideUnitSphere & 20f;
                NavMeshHit navHit;
                NavMesh.SamplePosition(transform.position + randomPos, out navHit, 20f, NavMesh.AllAreas);
            }
        }
        nav.SetDestination(player.transform.position);
	}
}
