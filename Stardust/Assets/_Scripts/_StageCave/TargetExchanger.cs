using UnityEngine;
using System.Collections;

public class TargetExchanger : MonoBehaviour {

	public GameObject[] TargetClass;
	//public GameObject Target;
	public GameObject ExchangedTarget;

	public GameObject ColliderDestory;
	// Use this for initialization
	/*
	void Awake()
	{
		//GameObject Target = new GameObject;
		GameObject[] TargetClass = new GameObject[4];
	}
	*/
	void Update () {
		StartCoroutine (totCaller ());
	}
	
	// Update is called once per frame
	IEnumerator totCaller()
	{
		yield return new WaitForSeconds (1);

		for (int i = 1; i < 4; i++) 
		{
			TargetClass [i].SetActive (false);
		}

		//Target.SetActive (false);
		ExchangedTarget.SetActive (true);
        ColliderDestory.GetComponent<Collider2D> ().enabled = false;
	}
}
