using UnityEngine;
using System.Collections;

public class CaveClearStar : MonoBehaviour {

	public GameObject ClearStar;
	public GameObject ExitTarget;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ExitTarget.activeInHierarchy == true) 
		{
			ClearStar.SetActive (true);
		}
	}
}
