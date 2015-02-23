using UnityEngine;
using System.Collections;

public class moneyScript : MonoBehaviour {
	
	public bool hasMoved = false;
	
	// Use this for initialization
	void Start () {
		hasMoved = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(hasMoved == true)
		{	
			transform.position += new Vector3(10 * Time.deltaTime, 0, 0);
		}
	}
}
