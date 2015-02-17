using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {

	int health = 3;
	void OnCollisionEnter2D (Collision2D col)
	{
		Debug.Log("collision name = " + col.gameObject.name);

		if ((col.gameObject.name == "BombTemp(Clone)")||(col.gameObject.name == "BombTemp"))
		{
			Destroy(col.gameObject);
			health=health -1;

			if (health <=0)
			{
				iflose ();
			}
			// lose condition (get hit by bomb)
		}
	}


	void iflose ()
	{

		Debug.Log("Lose!!!!");
		Destroy(gameObject);
	}
}
