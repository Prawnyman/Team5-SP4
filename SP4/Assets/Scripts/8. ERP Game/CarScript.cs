using UnityEngine;
using System.Collections;

public class CarScript : MonoBehaviour {
	
	private Vector3 speed = new Vector3(10.0f, 0, 0);
		
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += speed * Time.deltaTime;
		
		if(transform.position.x > 11)
		{
			Destroy(this.gameObject);
		}
	}
}
