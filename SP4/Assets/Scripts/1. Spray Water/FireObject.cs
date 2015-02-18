using UnityEngine;
using System.Collections;

public class FireObject : MonoBehaviour {
	
	private int hp;
	
	// Use this for initialization
	void Start () {
		hp = 10;
	}			
	// Update is called once per frame
	void Update () {
		if(hp <= 0)
		{
			this.transform.localScale -= new Vector3(1.0F, 1.0F, 0);
		}
		if(this.transform.localScale.x < 0.0f && this.transform.localScale.y < 0.0f)
		{
			Destroy(this.gameObject);
		}
	}
	
	void OnParticleCollision(GameObject other)
	{
		hp-=1;
	}
	
}