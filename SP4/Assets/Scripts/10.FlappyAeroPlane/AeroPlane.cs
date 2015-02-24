using UnityEngine;
using System.Collections;

public class AeroPlane : MonoBehaviour 
{

	public Vector2 jumpForce = new Vector2(0, 300);
	// Use this for initialization
	void Start () 
	{
	}
	
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
		if (Input.GetKeyUp("space"))
		{
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(jumpForce);
		}
	
	}
}
