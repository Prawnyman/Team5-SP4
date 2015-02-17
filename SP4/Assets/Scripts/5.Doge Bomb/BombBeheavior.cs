using UnityEngine;
using System.Collections;

public class BombBeheavior : MonoBehaviour {

	void OnBecameInvisible()
	{
		Destroy (gameObject);
	}
}
