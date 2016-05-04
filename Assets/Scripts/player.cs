using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
	NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit;

			if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hit, 100)) {
				agent.destination = hit.point;
			}
		}
	}
}

// MoveToClickPoint.cs
//using UnityEngine;
//
//public class MoveToClickPoint : MonoBehaviour {
//	NavMeshAgent agent;
//
//	void Start() {
//		agent = GetComponent<NavMeshAgent>();
//	}
//
//	void Update() {
//		if (Input.GetMouseButtonDown(0)) {
//			RaycastHit hit;
//
//			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) {
//				agent.destination = hit.point;
//			}
//		}
//	}
//}