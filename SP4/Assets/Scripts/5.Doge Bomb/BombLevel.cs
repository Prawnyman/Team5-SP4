using UnityEngine;
using System.Collections;

public class BombLevel : MonoBehaviour {
	public GameObject BombSpawner;
	public GameObject Player;

	bool checkLose = false;
	GameObject Timer;

	// Use this for initialization
	void Start () { 
		GlobalVariables.lastLevel = Application.loadedLevel;
		GameObject obj = Instantiate(Player) as GameObject;
		obj.transform.position.Set(0, -4.2f, 0);
		obj.tag = "Player";
		GameObject obj2 = Instantiate(BombSpawner) as GameObject;
		obj2.transform.position.Set(0, 0, 0);
		Timer = GameObject.FindGameObjectWithTag("timer");
	}
	
	// Update is called once per frame
	void Update () {
		GameObject checkPlayer = GameObject.FindGameObjectWithTag ("Player");

		if (Timer.GetComponent<TimerScript>().timeLeft <= 0)
		{
			if (checkPlayer != null) {
				StartCoroutine(Win());
			}
		}

		/*if (checkPlayer != null) {
			// Winning 
			//Timer Check
			//Application.LoadLevel("RubbleClear");
			//StartCoroutine(Win());
		}*/
		if (checkPlayer == null && checkLose == false) {
			checkLose = true;
			audio.Play ();
			StartCoroutine(Lose());
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
		yield return new WaitForSeconds (1.2f);
		Application.LoadLevel ("0B. Level Transition");
	}
}
