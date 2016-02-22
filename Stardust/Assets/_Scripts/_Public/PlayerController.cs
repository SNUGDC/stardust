﻿using UnityEngine;
using System.Collections;


public class PlayerController : MonoBehaviour {

	public bool facingRight = true;
	public float Speed;
	private Rigidbody2D rb;


	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
	{
		if (Input.GetMouseButton (0)) {
			MovePlayer ();
		} else if (Input.GetMouseButtonUp (0)) 
		{
			rb.velocity = new Vector2 (0, 0);
		}
	}
	void MovePlayer()
	{
		float touchPositionX = Input.mousePosition.x;
		Debug.Log (touchPositionX);

		if (Input.mousePosition.x >= (2 * Screen.width / 3) && facingRight)
		{
			rb.velocity = new Vector2 (1,0)* Speed * Time.deltaTime;

		}

		else if (Input.mousePosition.x < (Screen.width / 3) && !facingRight) 
		{
			rb.velocity = new Vector2 (-1, 0)* Speed * Time.deltaTime;	
		}
		else if (Input.mousePosition.x < (2 * Screen.width / 3) &&Input.mousePosition.x >= (Screen.width / 3)) 
		{
			rb.velocity = Vector2.zero * Speed * Time.deltaTime;
		}

		else if (Input.mousePosition.x >= (2 * Screen.width / 3) && !facingRight) 
		{
			Flip();
		}
		else if (Input.mousePosition.x < (Screen.width / 3) && facingRight) 
		{
			Flip ();
		}
	}

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x = -theScale.x;
		transform.localScale = theScale;
	}

}












