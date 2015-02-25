using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour 
{

	public GameObject Obstacles;
	int Score = 0;
	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("CreateObstacles", 8.0f, 6.0f);
	}

	void OnGui()
	{
//		GUI.color = Color.red;
//		GUILayout.Label (" Score: " + Score.ToString());
	}
	// Update is called once per frame
	void CreateObstacles()
	{
		Instantiate (Obstacles);
		Score++;
		Debug.Log (Score);
	}
	void Update ()
	{
	}
}
