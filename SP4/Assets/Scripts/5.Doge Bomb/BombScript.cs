using UnityEngine;
using System.Collections;
public class BombScript : MonoBehaviour
{
	public GameObject spawnType;
	public int spawnCount;
	public float spawnDelay;
	private float spawnPrev;

	// Use this for initialization
	void Start ()
	{
		spawnPrev = Time.time;
	}
	
	// Update is called once per frame
	void Update ()
	{

		float now = Time.time;
		float diff = (now - spawnPrev) * 1000;

		if (diff < spawnDelay) {
			return;
		}
		spawnPrev = now;

		for (int i=0; i<spawnCount; i++) {
			float x = Random.Range (-10, -1);
			float y = 5;

			Instantiate (spawnType, new Vector3 (x, y, 0), Quaternion.identity);

	
			x = Random.Range (0, 10);
			y = 6;
				
			Instantiate (spawnType, new Vector3 (x, y, 0), Quaternion.identity);

		}

	} 
	

	
}
	
