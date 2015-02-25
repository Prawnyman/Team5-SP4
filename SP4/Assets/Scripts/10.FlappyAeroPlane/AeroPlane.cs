using UnityEngine;
using System.Collections;

public class AeroPlane : MonoBehaviour 
{
	private float timer = 30;
	//float runTime;

	public Vector2 jumpForce = new Vector2(0, 300);
	// Use this for initialization
	void Start () 
	{
		//PlayerPrefs.GetFloat ("runTime", runTime);
	}

//	void End ()
//	{
//		GUI.Box(new Rect(10,10,380,150), "END OF THE GAME! \n\n YOUR Time IS " + timer );
//	}
//	void OnDestroy()
//	{
//		var savedTime = PlayerPrefs.GetFloat ("runTime");
//		PlayerPrefs.SetFloat ("runTime", savedTime + Time.timeSinceLevelLoad);
//		
//		Debug.Log (PlayerPrefs.GetFloat ("runTime"));
//	}

	void OnGUI () 
	{	
		if (timer > 0) 
		{
			GUI.color = Color.red; //Change Color
			GUI.Box (new Rect (310, 130, 100, 20), "Timer : " + (int)timer);
			//GUI.Box (new Rect (310, 130, 70, 20), "Timer : " + (int)Score);
		} else 
		{
			Die ();
		}

		//guiText.text = "Time: " + Time.timeSinceLevelLoad.ToString ("F2") + "\nTotal Time: " + PlayerPrefs.GetFloat ("runTime");
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
		timer -= Time.deltaTime;

		if (Input.GetKeyUp ("space"))
		{
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce (jumpForce);
		}

		Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0)
		{
			Die();
		}	
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		Die();
	}

	void Die()
	{
		Debug.Log ("Die");
		Application.LoadLevel (Application.loadedLevel); //Restart for now
	}
}
