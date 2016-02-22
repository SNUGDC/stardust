using UnityEngine;
using System.Collections;

public class SkyColorByChatshire : MonoBehaviour {

	public GameObject[] Chatshire;
	public GameObject[] SkyClass;

	// Use this for initialization
	void Start () {
//		Chatshire = GameObject.FindGameObjectsWithTag ("Chatshire") as GameObject[];
//		TargetClass = GameObject.FindGameObjectsWithTag ("SkyColor") as GameObject[];
	}
	
	// Update is called once per frame
	void Update () {
		if (Chatshire [0].activeInHierarchy == true) {
			SkyClass [0].SetActive (true);
			SkyClass [1].SetActive (false);
			SkyClass [2].SetActive (false);
		} else if (Chatshire [1].activeInHierarchy == true) {
			SkyClass [1].SetActive (true);
			SkyClass [0].SetActive (false);
			SkyClass [2].SetActive (false);
		} else if (Chatshire [2].activeInHierarchy == true) {
			SkyClass [2].SetActive (true);
			SkyClass [0].SetActive (false);
			SkyClass [1].SetActive (false);
		}
	}
}
