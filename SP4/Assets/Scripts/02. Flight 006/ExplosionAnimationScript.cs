using UnityEngine;
using System.Collections;

public class ExplosionAnimationScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (destroyExplosion());
	}

	private IEnumerator destroyExplosion(){
		yield return new WaitForSeconds (1.12f);
		DestroyObject(gameObject);
	}
}
