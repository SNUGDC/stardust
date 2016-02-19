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
	private int routine = 0;

	void Start ()
	{
		Arrow.gameObject.SetActive (false);
	}
	void Update()
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			if (active == true) {
				routine = 1;
			} 
			else 
			{
				routine = 2;
			}

			active = false;
		}
		if (routine == 1) {
			ArrowPosition ();
		} else if (routine == 2) {
			Arrow.gameObject.SetActive (false);	
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