using UnityEngine;
using System.Collections;

public class WW2GuardScript : MonoBehaviour {
	private Vector2 dir;
	private float speed = 5.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//this.transform.rotation = Quaternion.Euler(0, 0, 0);

		this.transform.Translate(dir * speed * Time.deltaTime);
	}

	public void setDir(float x, float y){
		if (x < 0)
			x = -1;
		else if(x > 0)
			x = 1;

		if(y < 0)
			y = -1;
		else if(y > 0)
			y = 1;

		dir.Set(x, y);
	}

	public void setSpeed(float newSpeed){
		speed = newSpeed;
	}
}
