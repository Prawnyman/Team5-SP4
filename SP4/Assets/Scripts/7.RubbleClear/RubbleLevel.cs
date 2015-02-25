using UnityEngine;
using System.Collections;

public class RubbleLevel : MonoBehaviour {
	public GameObject Rock;
	public GameObject Picture;
	// Use this for initialization
	void Start () {
		int z = 0;
		Instantiate (Picture);
		for (int i =0; i<5; i++)
		{
			float x = Random.Range (-8, 0);
			float y =Random.Range (0, 3);
			
			Instantiate (Rock, new Vector3 (x, y, z), Quaternion.identity);
			z++;
			 x = Random.Range (0, 8);
			 y =Random.Range (-3, 0);
			
			Instantiate (Rock, new Vector3 (x, y, z), Quaternion.identity);
			z++;

		}
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject checkRubble = GameObject.FindGameObjectWithTag ("Rock");
		
		if (checkRubble != null) {
			//losing
		} else {
			//Winning
			Debug.Log("Winner!");
		}
	}
}
