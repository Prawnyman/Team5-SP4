using UnityEngine;
using System.Collections;

public class PlaneScript : MonoBehaviour {
	private float initialRotation;

	// Use this for initialization
	void Start () {
		this.transform.position.Set(-7, 2.4f, 0);

		initialRotation = 0.0f;
		while(initialRotation > -5.0f && initialRotation < 5.0f){
			initialRotation = Random.Range(-35, 35);
		}
		this.transform.rotation = Quaternion.Euler(0, 0, initialRotation);
	}
	
	// Update is called once per frame
	void Update () {
		//Get tilt input
		float finalRotation = initialRotation + Input.acceleration.x * -70;
		
		//Limit amount of rotation plane can have
		if (finalRotation > 35.0f) {
			finalRotation = 35.0f;
		}
		else if(finalRotation < -35.0f){
			finalRotation = -35.0f;
		}

		//Update plane rotation
		this.transform.rotation = Quaternion.Euler(0, 0, finalRotation);
	}


}
