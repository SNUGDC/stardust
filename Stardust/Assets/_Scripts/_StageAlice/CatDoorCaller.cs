using UnityEngine;
using System.Collections;

public class CatDoorCaller : MonoBehaviour {

	public GameObject[] CatState;
	public GameObject Target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (CatState [1].activeInHierarchy == true && CatState [3].activeInHierarchy == true) {
			Target.SetActive (true);
			for (int i = 0; i < CatState.GetLength(0); i++) 
			{
				CatState [i].SetActive (false);
			}
			Target.SetActive (true);
			this.GetComponent<CatDoorCaller> ().enabled = false;
		} else 
		{
			Target.SetActive (false);
		}
	}
}
