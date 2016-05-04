using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
	public Transform goal;
    public float viewDistance = 3.5f;
    public float distToTarget = 0f;
	NavMeshAgent agent;
    
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}
	
	void Update () {
        distToTarget = Vector3.Distance(goal.position, this.transform.position);
        if(distToTarget < viewDistance) {
            agent.destination = goal.position;
        } 	 	
	}
}