using UnityEngine;
using System.Collections;

public class life : MonoBehaviour {
    public float maxLife;
    public float currentLife;

	void Start () {
        currentLife = maxLife;
	}
	
	void Update () {
        if (currentLife <= 0.0f) {
            Debug.Log("Dead!");
        }
	}
}