using UnityEngine;
using System.Collections;

public class SwipeControl : MonoBehaviour {
	
	public Transform moneyPrefab;
	private GameObject moneyGO;
	private bool moved;
	private Vector2 fp;
	private Vector2 lp;
	
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
					fp = touch.position;
					lp = touch.position;
					moneyGO = Instantiate(moneyPrefab, new Vector3(-6.5f, 0.5f, 1), Quaternion.identity) as GameObject;
				}
				if(touch.phase == TouchPhase.Moved)
				{
					lp = touch.position;
					float xChange = lp.x - fp.x;
				if(xChange > 250)
					{
						moneyGO.GetComponent<moneyScript>().hasMoved = true;
					}
				}
				if(touch.phase == TouchPhase.Ended && moneyGO.GetComponent<moneyScript>().hasMoved == false)
				{
					Destroy(moneyGO);
				}
			}
		}
				
	}
}