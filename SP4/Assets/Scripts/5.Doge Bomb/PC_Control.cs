using UnityEngine;
using System.Collections;

public class PC_Control : MonoBehaviour {
	Vector3 dir = Vector3.zero;
	float moveSpeed = 0.5f;
	float tempx = 0;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		dir.x = Input.acceleration.x * moveSpeed;
			transform.Translate (dir.x, 0, 0);
	}
}
