using UnityEngine;
using System.Collections;

public class Flight006Level : MonoBehaviour {
	public GameObject plane;
	public GameObject explosion;

	// Use this for initialization
	void Start () {
		GameObject obj = Instantiate(plane) as GameObject;
		obj.transform.position.Set(-7, 2.4f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		GameObject checkPlane = GameObject.FindGameObjectWithTag("Plane");

		if(checkPlane.GetComponent<PlaneScript>().getTouchedGround()){
			//Plane crashes
			if(checkPlane.GetComponent<PlaneScript>().getRotation() < -5.0f ||
			   checkPlane.GetComponent<PlaneScript>().getRotation() > 5.0f){
				//Lose
				GameObject obj = Instantiate(explosion, checkPlane.transform.position, Quaternion.identity) as GameObject;
				obj.tag = "";
				checkPlane.GetComponent<PlaneScript>().destroyPlane();
			}
			//Plane lands safely
			else{
				//Win
			}
		}
	}
}
