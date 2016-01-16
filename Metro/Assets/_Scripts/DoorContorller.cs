using UnityEngine;
using System.Collections;

public class DoorContorller : MonoBehaviour {

	Animator anim;
	public GameObject transfer;

	public float Interval;

	public GameObject[] Passengers;

	void Awake()
	{
		anim = GetComponent<Animator> ();

		Passengers = GameObject.FindGameObjectsWithTag ("Passengers");

	}

	void Update()
	{
		if (transfer.activeSelf) 
		{
			StartCoroutine(DoorAnimation());
		}

	}

	IEnumerator DoorAnimation()
	{

		anim.SetTrigger ("opendoor");

		yield return new WaitForSeconds (Interval);

		foreach (GameObject passenger in Passengers) 
		{
			passenger.GetComponentInChildren<Renderer>().sortingOrder = 0;
		}
	}

}
