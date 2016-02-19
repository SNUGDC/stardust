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

	void OnEnable()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		rb = GetComponent<Rigidbody2D> ();

	}

	void Update() 
	{	
		MovePlanet (); 

	}

	public void MovePlanet()
	{
		float playerPositionX = player.transform.position.x;


		if (player.GetComponent<PlayerController>().facingRight == true)
		{
			rb.transform.position = new Vector2 (playerPositionX + addPositionX, addPositionY);

		}

		if (player.GetComponent<PlayerController>().facingRight == false) 
		{
			rb.transform.position = new Vector2 ( playerPositionX + addPositionX, addPositionY);
		}
	}
}