using UnityEngine;
using System.Collections;

public class GUIforQuiz : MonoBehaviour 
{
	private bool correct = false;
	private int NumOfCorrect;
	private int NumOfIncorrect;
	//private bool handleTap(hit.collider.gameObject);

	void OnGUI () 
	{
		// Make a background box
		GUI.Box(new Rect(10,10,380,150), "Question 1. When did Singapore become independent?");
		
		// Make the First button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,220,20), "A. 9 March 1954")) 
		{
			//Application.LoadLevel(1);
			correct = false;
			Debug.Log("No");
		}
		
		// Make the sSecond button.
		if(GUI.Button(new Rect(20,70,220,20), "B. 3 April 1984")) 
		{
			//Application.LoadLevel(2);
			correct = false;
			Debug.Log("No");
		}

		// Make the Third button.
		if(GUI.Button(new Rect(20,100,220,20), "C. 9 August 1965")) 
		{
			//Application.LoadLevel(3);
			Debug.Log ("YAY");
		}

		// Make the Forth button.
		if(GUI.Button(new Rect(20,130,220,20), "D. 16 November 1975")) 
		{
			//Application.LoadLevel(4);
			correct = false;
			Debug.Log("No");
		}
		CheckRight ();
	}	
	//	// Use this for initialization
	//	void Start () {
	//	
	//	}
	
	public void CheckRight()
	{
		correct = true;
		
			NumOfIncorrect = 0;
			NumOfCorrect++;
			//Debug.Log (correct);

			if(NumOfCorrect == 1)
			{
				//Debug.Log("Yes1");
			}
			else
			{
				//Debug.Log ("incorrect");
			}
        
//		else
//		{
//			correct = false;
//			NumOfCorrect = 0;
//			NumOfIncorrect++;
//		 	//Debug.Log (correct);
//
//			if(NumOfIncorrect == 1)
//			{
//				//Debug.Log("no1");
//			}
//			else
//			{
//				//Debug.Log ("na na");
//			}
//		}
	}
	// Update is called once per frame
	void Update () 
	{
		if (Input.touchCount > 0)
		{
			if (this.GetComponent<GUITexture>().HitTest(Input.GetTouch(0).position))
			{
				//Debug.Log("touched");
			}
		}
//		int nbTouches = Input.touchCount;
//		
//		if(nbTouches > 0)
//		{
//			for (int i = 0; i < nbTouches; i++)
//			{
//				Touch touch = Input.GetTouch(i);
//				
//				if(touch.phase == TouchPhase.Began)
//				{
//					Ray screenRay = Camera.main.ScreenPointToRay(touch.position);
//					
//					RaycastHit hit;
//					if (Physics.Raycast(screenRay, out hit))
//					{
//						print("User tapped on game object " + hit.collider.gameObject.name);
//						handleTap(hit.collider.gameObject);
//					}
//				}
//			}
//		}
	}
}