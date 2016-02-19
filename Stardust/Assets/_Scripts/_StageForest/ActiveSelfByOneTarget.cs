using UnityEngine;
using System.Collections;

public class ActiveSelfByOneTarget : MonoBehaviour {

	public GameObject[] PlanetClass;
	public GameObject[] SkyClass;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (PlanetClass[0].activeInHierarchy == true) {
			//Debug.Log ("Work Well");
			for (int i = 0; i < 4; i++) 
			{
				SkyClass[i].gameObject.SetActive (false);
			}
			SkyClass[0].gameObject.SetActive (true);
		} 
		else if (PlanetClass[1].activeInHierarchy == true) {
			//Debug.Log ("Work Well");
			for (int i = 0; i < 4; i++) 
			{
				SkyClass[i].gameObject.SetActive (false);
			}
			SkyClass[1].gameObject.SetActive (true);
		} 
		if (PlanetClass[2].activeInHierarchy == true) {
			//Debug.Log ("Work Well");
			for (int i = 0; i < 4; i++) 
			{
				SkyClass[i].gameObject.SetActive (false);
			}
			SkyClass[2].gameObject.SetActive (true);
		} 
		if (PlanetClass[3].activeInHierarchy == true) {
			//Debug.Log ("Work Well");
			for (int i = 0; i < 4; i++) 
			{
				SkyClass[i].gameObject.SetActive (false);
			}
			SkyClass[3].gameObject.SetActive (true);
		} 

	}
}
