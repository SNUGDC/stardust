using UnityEngine;
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
		if (Input.GetMouseButton(0)) 
		{
			MovePlayer ();
		}
	}
	void MovePlayer()
	{
		float touchPositionX = Input.mousePosition.x;

		Vector2 touchVector = new Vector2 (touchPositionX / Mathf.Abs(touchPositionX), 0);

		if (Input.mousePosition.x >= (2 * Screen.width / 3) && facingRight)
		{
			rb.velocity = touchVector * Speed * Time.deltaTime;

		}

		if (Input.mousePosition.x < (Screen.width / 3) && !facingRight) 
		{
			rb.velocity = -touchVector * Speed * Time.deltaTime;	
		}
		if (Input.mousePosition.x < (2 * Screen.width / 3) &&Input.mousePosition.x >= (Screen.width / 3)) 
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












