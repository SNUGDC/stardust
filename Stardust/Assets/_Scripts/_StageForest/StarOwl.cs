using UnityEngine;
using System.Collections;

public class StarOwl : MonoBehaviour {

	public GameObject OwlState1;
	public GameObject OwlState2;
	public GameObject Star;
	// Use this for initialization
	void Start () {
		Star.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		if (OwlState1.activeInHierarchy == true || OwlState2.activeInHierarchy == true) 
		{
			Star.SetActive (true);
		}
	
	}
}
