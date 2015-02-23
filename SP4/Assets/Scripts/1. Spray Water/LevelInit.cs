using UnityEngine;
using System.Collections;

public class LevelInit : MonoBehaviour {
	
	public Transform firePrefab;
	static public int noFireObj = 0;
	
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 3; ++i)
		{
			Instantiate(firePrefab, new Vector3(Random.Range(-2.0f, 8.0f), Random.Range(-5.0f, 3.0f), 0), Quaternion.identity);
			noFireObj += 1;
		}
	}
		
	// Update is called once per frame
	void Update () {
			
		if(noFireObj <= 0)
		{
			Win ();
		}
	}
	
	void Lose (){}
	void Win(){
		
	}
}