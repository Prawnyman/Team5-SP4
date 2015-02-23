using UnityEngine;
using System.Collections;

public class WW2GuardScript : MonoBehaviour {
	private Vector2 dir;
	private float speed = 5.0f;
	private Vector2 oldPos;

	// Use this for initialization
	void Start () {
		oldPos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float magnitude = speed * Time.deltaTime;

		this.transform.Translate(new Vector2(0, 1) * magnitude);

		if((this.transform.position - new Vector3(oldPos.x, oldPos.y)).magnitude >= 8.0f){
			oldPos = this.transform.position;
			this.transform.Rotate(0, 0, 180);
		}
	}

	public void setDir(float x, float y){
		if(dir == Vector2.zero)
			dir = new Vector2(0, 1);

		if (x < 0)
			x = -1;
		else if(x > 0)
			x = 1;

		if(y < 0)
			y = -1;
		else if(y > 0)
			y = 1;

		this.transform.Rotate(0, 0, Vector2.Angle(dir, new Vector2(x, y)));
		dir.Set(x, y);
	}

	public void setSpeed(float newSpeed){
		speed = newSpeed;
	}
}
