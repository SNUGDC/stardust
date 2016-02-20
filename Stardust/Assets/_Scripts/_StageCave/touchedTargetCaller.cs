using UnityEngine;
using System.Collections;

public class touchedTargetCaller : MonoBehaviour {

	public GameObject Target;
	Vector3 tempPos;
	Vector3 temp;
	int routine = 0;
	public bool active = false;
    public bool targetActive = false;
	public float smoothTime = 0.18f;

	private Vector3 velocity;

	public enum eState
	{
		None,

		Contact
	}

	eState paperState;

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.tag == "Player") 
		{
			paperState = eState.Contact;
		    active = false;
		}
	}

	void OnTriggerExit2D(Collider2D coll)
	{
	    if (coll.tag == "Player")
	    {
	        paperState = eState.None;
	        Target.SetActive(false);
	    }
	}

	void Start () {

		tempPos = Target.transform.position;
		Target.SetActive (false);
	}
	void Update()
	{
		Touch ();
		if (routine == 1) 
		{
			TargetCall ();
		}

		if (routine == 2) 
		{	
			//Target.SetActive (false);
		}
	}
	void OnMouseDown()//change start position of Palette
	{
		active = true;
		Target.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	}

	void Touch()
	{
		if (paperState == eState.Contact && Input.GetMouseButtonDown(0)) 
		{
			if (active == true) 
			{
				routine = 1;
			}
			else if (active == false && targetActive == false)
			{
				routine = 2;
			}
		    targetActive = false;
			active = false;
		}
	}

	void TargetCall ()
	{
		Target.SetActive (true);
		temp = Vector3.SmoothDamp (Target.transform.position, tempPos, ref velocity, smoothTime);
		Target.transform.position = temp;
	}
}