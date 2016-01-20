using UnityEngine;
using System.Collections;

public class DoorContorller : MonoBehaviour {

	Animator anim;
	public GameObject transfer;
    public GameObject Girl;

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

        Girl.GetComponent<GirlController>().Go = true;
		foreach (GameObject passenger in Passengers) 
		{
			passenger.GetComponent<Renderer>().sortingOrder = 0;
		}
	}

}
