using UnityEngine;
using System.Collections;

public class WW2LevelScript : MonoBehaviour {
	public GameObject character;
	public GameObject guard;

	private GameObject theCharacter;

	// Use this for initialization
	void Start () {
		//Create character
		GameObject newCharacter = Instantiate(character, new Vector3(-8.2f, 0, 0), Quaternion.identity) as GameObject;
		newCharacter.tag = "Character";
		theCharacter = newCharacter;

		//Create guards
		GameObject newGuard = Instantiate(guard, new Vector3(-4.8f, -4, 0), Quaternion.identity) as GameObject;
		newGuard.GetComponent<WW2GuardScript>().setDir(0, 1);

		newGuard = Instantiate(guard, new Vector3(0, 4, 0), Quaternion.identity) as GameObject;
		newGuard.GetComponent<WW2GuardScript>().setDir(0, -1);

		newGuard = Instantiate(guard, new Vector3(4.8f, -4, 0), Quaternion.identity) as GameObject;
		newGuard.GetComponent<WW2GuardScript>().setDir(0, 1);
	}
	
	// Update is called once per frame
	void Update () {

		//Checks if player has reached endpoint
		if(theCharacter.GetComponent<WW2CharacterScript>().getReachedEndpoint()){
			Win();
		}
		else if(theCharacter.GetComponent<WW2CharacterScript>().getCaughtByGuards()){
			Lose ();
		}
	}

	void Win(){

	}
	void Lose(){

	}
}
