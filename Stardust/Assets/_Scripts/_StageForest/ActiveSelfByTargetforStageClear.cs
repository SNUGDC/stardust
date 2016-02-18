using UnityEngine;
using System.Collections;

public class ActiveSelfByTargetforStageClear : MonoBehaviour {

	public GameObject[] Target;
	public GameObject Root;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Target[0].activeInHierarchy == true && Target[1].activeInHierarchy == true) {
			//Debug.Log ("Work Well");
			Root.gameObject.SetActive (true);
		} 
		else 
		{
			this.gameObject.SetActive (false);
		}
	
	}
}
