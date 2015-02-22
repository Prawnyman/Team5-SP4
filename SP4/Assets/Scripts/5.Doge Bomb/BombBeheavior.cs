using UnityEngine;
using System.Collections;

public class BombBeheavior : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D col)
	{
		Debug.Log("collision name = " + col.gameObject.name);
		if (col.gameObject.name == "Wall")
		{
				Destroy(gameObject);
		}
	}
	void OnBecameInvisible()
	{
		Destroy (gameObject);
	}
}
