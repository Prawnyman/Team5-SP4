using UnityEngine;
using System.Collections;

public class WW2CharacterScript : MonoBehaviour {
	Vector2 dir = new Vector2(0, 1);
	bool reachedEndpoint = false;
	bool caughtByGuards = false;

	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 newDir = new Vector2();

#if UNITY_ANDROID
		if(Input.touches.Length > 0){
			Vector2 pos = this.transform.position;
			Vector2 pt = Camera.main.ScreenToWorldPoint(Input.touches[0].position);

			newDir = (pt - pos).normalized;
			animator.SetBool("isMoving", true);
		}
		else{
			newDir.Set(0, 0);
			animator.SetBool("isMoving", false);
		}
#endif
#if UNITY_EDITOR
		if(Input.GetMouseButton(0)){
			Vector2 pos = this.transform.position;
			Vector2 pt = Camera.main.ScreenToWorldPoint(Input.mousePosition);

			newDir = (pt - pos).normalized;
			animator.SetBool("isMoving", true);
		}
		else{
			newDir.Set(0, 0);
			animator.SetBool("isMoving", false);
		}
#endif
		if(!caughtByGuards && !reachedEndpoint){
			if(newDir != new Vector2(0, 0)){
				this.transform.Rotate(0, 0, Vector2.Angle(dir, newDir));
				dir = newDir;
			}

			if(animator.GetBool("isMoving"))
				this.transform.Translate(new Vector2(0, 1) * Time.deltaTime * 5);
		}
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
