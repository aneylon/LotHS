using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {
    public GameObject target;
    //public Transform target;
    public float distance = 10.0f;

	void Start () {
        target = GameObject.FindGameObjectWithTag("Player");
	}

    void Update () {
        Vector3 newPosition = new Vector3(target.transform.position.x,target.transform.position.y + distance, target.transform.position.z - distance);
        transform.position = Vector3.Lerp(transform.position, newPosition,0.5f);
        transform.LookAt(target.transform);
	}
}
