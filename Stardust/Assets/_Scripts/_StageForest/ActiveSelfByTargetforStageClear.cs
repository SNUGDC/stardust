using UnityEngine;
using System.Collections;

public class ActiveSelfByTargetforStageClear : MonoBehaviour {

	public GameObject[] Target;
	public GameObject[] RootClass;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 2; i++) 
		{
			RootClass [i].gameObject.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (Target[0].activeInHierarchy == true && Target[1].activeInHierarchy == true) {
			//Debug.Log ("Work Well");
			for (int i = 0; i < 2; i++) 
			{
				RootClass [i].gameObject.SetActive (true);
			}
		} 
		else 
		{
			for (int i = 0; i < 2; i++) 
			{
				RootClass [i].gameObject.SetActive (false);
			}
		}
	
	}
}
