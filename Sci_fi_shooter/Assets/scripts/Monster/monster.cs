using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour {
    public GameObject player;

    private NavMeshAgent nav;

	// Use this for initialization
	void Start () {
        nav = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        nav.SetDestination(player.transform.position);
	}
}
