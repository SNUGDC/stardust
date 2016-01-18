using UnityEngine;
using System.Collections;

public class ParticleController : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Event e = Event.current;
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) {
		}
		//if(e.clickCount
	}
}
