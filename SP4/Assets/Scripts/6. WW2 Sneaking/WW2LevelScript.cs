using UnityEngine;
using System.Collections;

public class WW2LevelScript : MonoBehaviour {
	public GameObject character;
	public GameObject guard;
	public GameObject endpoint;

	// Use this for initialization
	void Start () {
		//Create character
		GameObject newCharacter = Instantiate(character, new Vector3(-8.2f, 0, 0), Quaternion.identity) as GameObject;
		newCharacter.tag = "Character";

		//Create guards
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
