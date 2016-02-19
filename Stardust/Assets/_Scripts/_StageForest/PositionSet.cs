using UnityEngine;
using System.Collections;

public class PositionSet : MonoBehaviour {

	private GameObject player;
	//private GameObject planet;
	private Rigidbody2D rb;
	public float addPositionY;
	public float addPositionX;

	void Start ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		rb = GetComponent<Rigidbody2D> ();

	}
	void FixedUpdate() 
	{	
		MovePlanet (); 

	}

	void MovePlanet()
	{
		float playerPositionX = player.transform.position.x;


		if (Input.mousePosition.x >= (2 * Screen.width / 3) && player.GetComponent<PlayerController>().facingRight == true)
		{
			rb.transform.position = new Vector2 (playerPositionX + addPositionX, addPositionY);

		}

		if (Input.mousePosition.x < (Screen.width / 3) && player.GetComponent<PlayerController>().facingRight == false) 
		{
			rb.transform.position = new Vector2 ( playerPositionX + addPositionX, addPositionY);
		}
	}


}