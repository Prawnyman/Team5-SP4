using UnityEngine;
using System.Collections;

public class RubbleLevel : MonoBehaviour {
	public GameObject Rock;
	public GameObject Picture;

	GameObject Timer;
	bool checkLose = false;
	// Use this for initialization
	void Start () {
		//audio.Play();
		GlobalVariables.lastLevel = Application.loadedLevel;
		int z = 0;
		Instantiate (Picture);
		for (int i =0; i<2; i++)
		{
			float x = Random.Range (-7, 0);
			float y =Random.Range (0, 4);
			
			Instantiate (Rock, new Vector3 (x, y, z), Quaternion.identity);
			z++;
			 x = Random.Range (0, 7);
			 y =Random.Range (-4, 0);
			
			Instantiate (Rock, new Vector3 (x, y, z), Quaternion.identity);
			z++;
		}
		Timer = GameObject.FindGameObjectWithTag("timer");
	}
	
	// Update is called once per frame
	void Update () {
		GameObject checkRubble = GameObject.FindGameObjectWithTag ("Rock");

		if (Timer.GetComponent<TimerScript>().timeLeft <= 0) {
			if (checkRubble != null && checkLose == false) {
				checkLose = true;
				audio.Play();
				StartCoroutine(Lose ());
			}
		}

		if (checkRubble == null) {
			StartCoroutine(Win ());
		}
	}

	private IEnumerator Win()
	{
		GlobalVariables.levelPassed = true;
		yield return new WaitForSeconds (0.8f);
		Application.LoadLevel ("0B. Level Transition");
	}

	private IEnumerator Lose()
	{
		GlobalVariables.levelPassed = false;
		yield return new WaitForSeconds (0.8f);
		Application.LoadLevel ("0B. Level Transition");
	}
}
