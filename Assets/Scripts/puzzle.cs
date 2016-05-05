using UnityEngine;
using System.Collections;

public class puzzle : MonoBehaviour {
    public GameObject targetPlayer;
    public float activeateDistance = 1.0f;
    public float timer = 5.0f;
    public float dist;
    public Material activeMat;
    public Material notActiveMat;
    public GameObject activeLight;

	void Update () {
        dist = Vector3.Distance(targetPlayer.transform.position, transform.position);
        if (dist <= activeateDistance) {
            activeLight.GetComponent<Renderer>().material = activeMat;
        }
        if (dist >= activeateDistance) {
            activeLight.GetComponent<Renderer>().material = notActiveMat;
        }
	}
}