using UnityEngine;
using System.Collections;

public class PlaneScript : MonoBehaviour {
	private float initialRotation;
	private float finalRotation;
	private bool touchedGround;

	// Use this for initialization
	void Start () {
		initialRotation = 0.0f;
		while(initialRotation > -5.0f && initialRotation < 5.0f){
			initialRotation = Random.Range(-35, 35);
		}

		finalRotation = initialRotation;
		touchedGround = false;

		this.transform.rotation = Quaternion.Euler(0, 0, finalRotation);
	}
	
	// Update is called once per frame
	void Update () {
		if(!touchedGround){
#if UNITY_ANDROID
			//Get tilt input
			finalRotation = initialRotation + Input.acceleration.x * -70;
#endif
			
			
#if UNITY_EDITOR
			if(Input.GetKey(KeyCode.LeftArrow)){
				finalRotation += 20.0f;
			}
			if(Input.GetKey(KeyCode.RightArrow)){
				finalRotation -= 20.0f;
			}
#endif

			//Limit amount of rotation plane can have
			if (finalRotation > 35.0f) {
				finalRotation = 35.0f;
			}
			else if(finalRotation < -35.0f){
				finalRotation = -35.0f;
			}
			
			//Update plane rotation
			this.transform.rotation = Quaternion.Euler(0, 0, finalRotation);

			//Plane constantly moves downwards
			//this.transform.Translate(0.2f * Time.deltaTime, -0.15f * Time.deltaTime, 0);
			this.transform.Translate((Vector3.down + Vector3.right * 2) * Time.deltaTime, Space.World);
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Ground"){
			touchedGround = true;
		}
	}

	public bool getTouchedGround(){
		return touchedGround;
	}

	public float getRotation(){
		return finalRotation;
	}

	public void destroyPlane(){
		DestroyObject(gameObject);
	}
}
