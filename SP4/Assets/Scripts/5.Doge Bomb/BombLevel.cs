using UnityEngine;
using System.Collections;

public class BombLevel : MonoBehaviour {
	public GameObject BombSpawner;
	public GameObject Player;

	// Use this for initialization
	void Start () {
		GameObject obj = Instantiate(Player) as GameObject;
		obj.transform.position.Set(0, -4.2f, 0);
		obj.tag = "Player";
		GameObject obj2 = Instantiate(BombSpawner) as GameObject;
		obj2.transform.position.Set(0, 0, 0);

	}
	
	// Update is called once per frame
	void Update () {
		GameObject checkPlayer = GameObject.FindGameObjectWithTag ("Player");

		if (checkPlayer != null) {
			// Winning 
			//Timer Check
		} else {
			//lose
			Debug.Log("Lose!!!!");
		}

	}
}
