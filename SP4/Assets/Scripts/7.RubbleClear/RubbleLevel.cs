using UnityEngine;
using System.Collections;

public class RubbleLevel : MonoBehaviour {
	public GameObject Rock;
	public GameObject Picture;
	public GameObject Picture2;
	// Use this for initialization
	void Start () {
		int z = 0;
		float pic = Random.Range (1, 10);
		if (pic < 5) {
			Instantiate (Picture);
		} else {
			Instantiate (Picture2);
		}


		for (int i =0; i<3; i++)
		{
			float x = Random.Range (-7, 0);
			float y =Random.Range (-4, 0);
			Instantiate (Rock, new Vector3 (x, y, z), Quaternion.identity);
			z++;

			 x = Random.Range (-7, 0);
			 y =Random.Range (0, 4);
			Instantiate (Rock, new Vector3 (x, y, z), Quaternion.identity);
			z++;

			x = Random.Range (0, 7);
			y =Random.Range (-4, 0);
			Instantiate (Rock, new Vector3 (x, y, z), Quaternion.identity);
			z++;

			x = Random.Range (0, 7);
			y =Random.Range (0, 4);
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
