using UnityEngine;
using System.Collections;

public class ActiveSelfByTarget : MonoBehaviour {

	public GameObject[] Target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Target[0].activeInHierarchy == true || Target[1].activeInHierarchy == true)
		{
			this.gameObject.SetActive (true);
		} 
		else if(Target[0].activeInHierarchy == false && Target[1].activeInHierarchy == false)
		{
			this.gameObject.SetActive (false);
		}
	
	}
}
