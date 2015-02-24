using UnityEngine;
using System.Collections;

public class WW2CharacterScript : MonoBehaviour {
	Vector2 dir = new Vector2(0, 0);
	bool reachedEndpoint = false;
	bool caughtByGuards = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
#if UNITY_ANDROID
		if(Input.touches.Length > 0){
			Vector2 pos = this.transform.position;
			Vector2 pt = Camera.main.ScreenToWorldPoint(Input.touches[0].position);

			dir = (pt - pos).normalized;
		}
		else{
			dir.Set(0, 0);
		}
#endif
#if UNITY_EDITOR
		if(Input.GetMouseButton(0)){
			Vector2 pos = this.transform.position;
			Vector2 pt = Camera.main.ScreenToWorldPoint(Input.mousePosition);

			dir = (pt - pos).normalized;
		}
		else{
			dir.Set(0, 0);
		}
#endif
		if(!caughtByGuards && !reachedEndpoint)
			this.transform.Translate(dir * Time.deltaTime * 5);
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "WW2 Endpoint"){
			reachedEndpoint = true;
		}
		else if(col.gameObject.tag == "WW2 Guard" || col.gameObject.tag == "WW2 Guard_vision"){
			caughtByGuards = true;
		}
	}


	public bool getReachedEndpoint(){
		return reachedEndpoint;
	}
	public bool getCaughtByGuards(){
		return caughtByGuards;
	}
}
