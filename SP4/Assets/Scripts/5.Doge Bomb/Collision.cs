using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {
	public GameObject explosion;
	int health = 3;
	void OnCollisionEnter2D (Collision2D col)
	{
		Debug.Log("collision name = " + col.gameObject.name);
		if ((col.gameObject.name == "BombTemp(Clone)")||(col.gameObject.name == "BombTemp"))
		{
			Destroy(col.gameObject);
			health=health -1;
			GameObject obj = Instantiate(explosion, gameObject.transform.position, Quaternion.identity) as GameObject;
			obj.tag = "";
			if (health <=0)
			{
				Destroy(gameObject);
			}
			// lose condition (get hit by bomb)
		}
	}

}
