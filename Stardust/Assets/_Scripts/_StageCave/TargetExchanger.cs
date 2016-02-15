using UnityEngine;
using System.Collections;

public class TargetExchanger : MonoBehaviour {


	public GameObject Target;
	public GameObject ExchangedTarget;

	public GameObject ColliderDestory;
	// Use this for initialization
	/*
	void Awake()
	{
		GameObject Target = new GameObject;
		//GameObject[] TargetClass = new GameObject[4];
	}
	*/
	void Update () {
		StartCoroutine (totCaller ());
	}
	
	// Update is called once per frame
	IEnumerator totCaller()
	{
		yield return new WaitForSeconds (1);

		Target.SetActive (false);

		ExchangedTarget.SetActive (true);
        ColliderDestory.GetComponent<Collider2D> ().enabled = false;
	}
}
