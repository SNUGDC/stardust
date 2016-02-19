using UnityEngine;
using System.Collections;

public class ArrowSet : MonoBehaviour {

	public GameObject Planet;
	public GameObject Arrow;
	//private GameObject planet;
	private Rigidbody2D rb;
	public float addPositionX;
	public float addPositionY;
	private bool active = false;
	//private int routine = 0;

	void Start ()
	{
		Arrow.gameObject.SetActive (false);
	}
	void FixedUpdate()
	{
		if (active == true) {
			//routine = 1;
			ArrowPosition ();
		} 
		else if(active == false)		
		{
			//routine = 0;
			Arrow.gameObject.SetActive (false);	
		}
		else if ( Planet.activeInHierarchy == false)
		{
			active = false;
		}
	}

	void ArrowPosition()
	{
		float PlanetPositionX = Planet.transform.position.x;
		Arrow.gameObject.SetActive (true);
		Arrow.transform.position = new Vector2 (PlanetPositionX + addPositionX, addPositionY);
	}

	void OnMouseDown()
	{
		Debug.Log ("fuck");
		active = true;
	}
}