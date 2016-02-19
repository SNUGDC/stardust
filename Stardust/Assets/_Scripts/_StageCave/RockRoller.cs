using UnityEngine;
using System.Collections;

public class RockRoller : MonoBehaviour {

	private float rockCount = 0;
	public GameObject Player;
	public GameObject Rat;
	public float Distance;
	public float Speed;
	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 PlayerPosition = Player.transform.position;
		Vector3 RatPosition = Rat.transform.position;

		if (rockCount == 1) 
		{
			if (Mathf.Abs (PlayerPosition.x - RatPosition.x) < Distance) {
				this.transform.Translate (new Vector3 (Time.deltaTime * Speed, 0, 0));
			} 
			else 
			{
				rockCount = 0;
			}
		} 
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "RatShadow") 
		{
			Debug.Log ("fuck");
			rockCount = 1;
		}
	}
	void OnTriggerExit2D()
	{
		rockCount = 0;
	}
}
