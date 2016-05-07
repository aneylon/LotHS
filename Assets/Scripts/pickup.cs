using UnityEngine;
using System.Collections;

public class pickup : MonoBehaviour {
    public Transform pickupParticles;
    public float rotateSpeed;
	void Update () {
        transform.Rotate(Vector3.up * (Time.deltaTime * rotateSpeed));
	}
    void OnTriggerEnter(Collider other) {
        if(other.tag == "Player") {
            Debug.Log("Pick it up");
            Instantiate(pickupParticles,transform.position,Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
