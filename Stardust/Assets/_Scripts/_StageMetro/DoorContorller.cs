using UnityEngine;
using System.Collections;

public class DoorContorller : MonoBehaviour {

	Animator anim;
	public GameObject transfer;
    public GameObject Collidercontroll;

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

        Collidercontroll.GetComponent<ColliderControll>().Condition = true;
		foreach (GameObject passenger in Passengers) 
		{
			passenger.GetComponent<Renderer>().sortingOrder = 0;
		}
	}

}
