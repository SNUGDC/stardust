using UnityEngine;
using System.Collections;

public class RockStar : MonoBehaviour {
	private GameObject RollingRock;
	private bool StarActive;
	public GameObject CaveStar;

	// Use this for initialization
	void Start () {
		RollingRock = GameObject.Find ("rock");
		CaveStar.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (StarActive == true) 
		{
			CaveStar.SetActive (true);
		}
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other == RollingRock) {
			StarActive = true;
		}
	}
}
