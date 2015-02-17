using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D col)
	{
		Debug.Log("collision name = " + col.gameObject.name);

		if ((col.gameObject.name == "BombTemp(Clone)")||(col.gameObject.name == "BombTemp"))
		{
			Destroy(col.gameObject);
			// lose condition (get hit by bomb)
		}
	}
}
