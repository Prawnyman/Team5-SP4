using UnityEngine;
using System.Collections;

public class GantryScript : MonoBehaviour {
	
	private enum Lanes{
		Top,
		Mid,
		Btm,
	};
	
	Lanes currentLane;
	
	Vector3 SetPosition()
	{
		Vector3 position = new Vector3(0, 0, 0);
	
		if(currentLane == Lanes.Top)
		{
			position = new Vector3(9, 3, 0);
		}
		else if(currentLane == Lanes.Mid)
		{
			position = new Vector3(9, 0.2f, 0);
		}
		else if(currentLane == Lanes.Btm)
		{
			position = new Vector3(9, -2.6f, 0);
		}
		
		return position;
	}
	
	void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.gameObject.tag == "Car")
		{
			Destroy(collider.gameObject);
		}
	}
	
	// Use this for initialization
	void Start () {
		currentLane = Lanes.Mid;
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = SetPosition();
	
		if(Input.GetKeyDown("up") )
		{
			if(currentLane == Lanes.Mid)
			{
				currentLane = Lanes.Top;
			}
			if(currentLane == Lanes.Btm)
			{
				currentLane = Lanes.Mid;
			}
		}
		if(Input.GetKeyDown("down"))
		{
			if(currentLane == Lanes.Mid)
			{
				currentLane = Lanes.Btm;
			}
			if(currentLane == Lanes.Top)
			{
				currentLane = Lanes.Mid;
			}
		}
	}
}
