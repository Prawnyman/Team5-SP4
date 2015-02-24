using UnityEngine;
using System.Collections;

public class CashCollider : MonoBehaviour {
	
	public Transform coinPrefab;
	private int moneyCount = 0;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(moneyCount >= 10)
		{
			Win ();
		}
	}
	
	void OnCollisionEnter2D(Collision2D collider)
	{
		if(collider.gameObject.tag == "MoneyClone")
		{
			Destroy(collider.gameObject);
			Instantiate(coinPrefab, collider.transform.position, Quaternion.identity);
			moneyCount += 1;
		}	
	}
	
	void Win()
	{
		
	}
}
