using UnityEngine;
using System.Collections;

public class StarAlpaca : MonoBehaviour {

	public GameObject PinkAlpaca;
	public GameObject starAlpaca;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (PinkAlpaca.activeInHierarchy == true) 
		{
			starAlpaca.SetActive (true);
		}
	}
}
