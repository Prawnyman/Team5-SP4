using UnityEngine;
using System.Collections;

public class AeroPlane : MonoBehaviour 
{
	//private float timer = 30;
	public float FlySpeed = 1.0f;
	public Vector2 jumpForce = new Vector2(0, 300);
	Vector3 velocity = Vector3.zero;
	//public float maxSpeed = 5.0f;
	//public Vector3 gravity;
	// Use this for initialization
	void Start () 
	{
	}

//	void OnGUI () 
//	{	
//		if (timer > 0) 
//		{
//			GUI.color = Color.red; //Change Color
//			GUI.Box (new Rect (310, 130, 100, 20), "Timer : " + (int)timer);
//			//GUI.Box (new Rect (310, 130, 70, 20), "Timer : " + (int)Score);
//		} else 
//		{
//			Die ();
//		}
//	
//	}	
	// Update is called once per frame
	void Update () 
	{		
//		if (Input.touchCount > 0)
//		{
//			if (this.GetComponent<GUITexture>().HitTest(Input.GetTouch(0).position))
//			{
//				//Debug.Log("touched");
//				rigidbody2D.velocity = Vector2.zero;
//				rigidbody2D.AddForce(jumpForce);
//			}
//		}
		//timer -= Time.deltaTime;

		if (Input.GetKeyUp ("space"))
		{
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce (jumpForce);
		}

		Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0)
		{
			//Die();
		}	
	}

	void FixedUpdate()
	{
		rigidbody2D.AddForce (Vector2.right * FlySpeed);

//		velocity.x = FlySpeed;
//		velocity += gravity;
//		transform.position += velocity * Time.deltaTime;
	}
//	void OnCollisionEnter2D(Collision2D other)
//	{
//		Die();
//	}
//
//	void Die()
//	{
//		Debug.Log ("Die");
//		Application.LoadLevel (Application.loadedLevel); //Restart for now
//	}
}
