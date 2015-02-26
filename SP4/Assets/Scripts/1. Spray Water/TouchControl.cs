using UnityEngine;
using System.Collections;

public class TouchControl : MonoBehaviour {
	private Vector2 fp;
	private Vector2 lp;
	
	// Use this for initialization
	void Start () {
		this.GetComponent<ParticleEmitter>().emit = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		if(this.GetComponent<ParticleEmitter>().emit == true && audio.isPlaying == false)
		{
			audio.Play ();
		}
		else if(this.GetComponent<ParticleEmitter>().emit == false)
		{
			audio.Stop();
		}
	
		if(Input.touches.Length > 0)
		{
			if(Input.touchCount == 1)
			{
				Touch touch = Input.GetTouch(0);
			
				if(touch.phase == TouchPhase.Began){
					fp = touch.position;
					lp = touch.position;
					this.GetComponent<ParticleEmitter>().emit = true;
				}
				if(touch.phase == TouchPhase.Moved){
					lp = touch.position;
				
					float yChange = lp.y - fp.y;
					transform.Rotate(new Vector3(0, 0, 1), yChange * 10 * Time.deltaTime);
				
					fp = touch.position;
				}
				
				if(touch.phase == TouchPhase.Ended)
				{
					this.GetComponent<ParticleEmitter>().emit = false;
					audio.Stop();
				}
			}
		}	
	}
}
