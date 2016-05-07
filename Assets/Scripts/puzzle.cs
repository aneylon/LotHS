using UnityEngine;
using System.Collections;

public class puzzle : MonoBehaviour {
    public GameObject targetPlayer;
    public GameObject puzzleLight;
    public float activeateDistance = 0.6f;
    public float timer = 5.0f;
    public float startTime = 0.0f;
    public Material activeMat;
    public Material notActiveMat;
    public GameObject activeLight;
    public bool lightOn = false;

	void Update () {
        if(lightOn && Time.time >= startTime + timer) {
            activeLight.GetComponent<Renderer>().material = notActiveMat;
            lightOn = false;
            puzzleLight.GetComponent<Light>().enabled = false;
            startTime = 0.0f;
        }
    }

    void OnTriggerEnter(Collider other) {
        if (!lightOn) {
        activeLight.GetComponent<Renderer>().material = activeMat;
        puzzleLight.GetComponent<Light>().enabled = true;
        lightOn = true;
            startTime = Time.time;
        }
    }
}