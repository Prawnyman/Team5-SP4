using UnityEngine;
using System.Collections;

public class SwipeControl : MonoBehaviour {
	
	public Transform moneyPrefab;
	private GameObject moneyGO;
	private bool moved;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.touches.Length > 0)
		{
			if(Input.touchCount == 1)
			{
				Touch touch = Input.GetTouch(0);
				
				if(touch.phase == TouchPhase.Began)
				{
					moneyGO = Instantiate(moneyPrefab, new Vector3(-6.5f, 0.5f, 1), Quaternion.identity) as GameObject;
				}
				if(touch.phase == TouchPhase.Moved)
				{
					moneyGO.GetComponent<moneyScript>().hasMoved = true;
				}
				if(touch.phase == TouchPhase.Ended && moneyGO.GetComponent<moneyScript>().hasMoved == false)
				{
					Destroy(moneyGO);
				}
			}
		}
				
	}
}