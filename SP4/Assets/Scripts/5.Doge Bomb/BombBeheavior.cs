using UnityEngine;
using System.Collections;

public class BombBeheavior : MonoBehaviour {
	public GameObject Boom;
	void OnCollisionEnter2D (Collision2D col)
	{
		Debug.Log("collision name = " + col.gameObject.name);
		if (col.gameObject.name == "Wall")
		{
			Destroy(gameObject);
			GameObject obj = Instantiate(Boom, gameObject.transform.position, Quaternion.identity) as GameObject;
		}
	}
	void OnBecameInvisible()
	{
		Destroy (gameObject);
	}
}
