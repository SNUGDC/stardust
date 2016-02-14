using UnityEngine;
using System.Collections;

public class touchedTargetCaller : MonoBehaviour {

	public GameObject Target;
	Vector3 tempPos;
	Vector3 temp;
	int routine = 0;
	public bool active = false;
	public float smoothTime = 0.18f;

	private Vector3 velocity;

	public enum eState
	{
		None,

		Contact
	}

	eState paperState;

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Player") 
		{
			paperState = eState.Contact;
		} 
	}

	void OnCollisionExit2D(Collision2D coll)
	{
		paperState = eState.None;
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
			Target.SetActive (false);
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
			else 
			{
				routine = 2;
			}
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