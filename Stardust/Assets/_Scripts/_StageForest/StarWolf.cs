using UnityEngine;
using System.Collections;

public class StarWolf : MonoBehaviour {

	public GameObject WolfHappy;
	public GameObject Star;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (WolfHappy.activeInHierarchy == true) 
		{
			Star.SetActive (true);
		}
	}
}
