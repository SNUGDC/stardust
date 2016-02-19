using UnityEngine;
using System.Collections;

public class OwlHoot : MonoBehaviour {

	public GameObject OwlDefault;
	public GameObject OwlAngry;
	public GameObject OwlSleep;
	public GameObject WithoutHatWake;
	public GameObject WithoutHatSleep;
	private int totalCount;
	private int colliderCount = 0;
	public GameObject[] DayClass;
	public GameObject[] NightClass;
	private bool hatOff = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (DayClass [0].activeInHierarchy == true || DayClass [1].activeInHierarchy == true) {
			OwlSleep.SetActive (true);
			OwlDefault.SetActive (false);
			OwlAngry.SetActive (false);
			totalCount = 0;// consider about totalCount
			if (hatOff == true ) 
			{
				Debug.Log ("withoutHat");
				WithoutHatWake.SetActive (false);
				OwlSleep.SetActive (false);
				OwlDefault.SetActive (false);
				OwlAngry.SetActive (false);
				WithoutHatSleep.SetActive (true);
			}
		} else if (NightClass [0].activeInHierarchy == true || NightClass [1].activeInHierarchy == true)
		{
			OwlSleep.SetActive (false);
			if (hatOff == false) 
			{
				if (totalCount < 6) {
					if (colliderCount == 1) {
						OwlAngry.SetActive (true);
						OwlDefault.SetActive (false);
					} else if (colliderCount == 0) {
						OwlAngry.SetActive (false);
						OwlDefault.SetActive (true);
					} 
				} else if (totalCount >= 6) {
					Debug.Log ("withoutHat");
					OwlAngry.SetActive (false);
					OwlDefault.SetActive (false);
					WithoutHatWake.SetActive (true);
					hatOff = true;
				} 
			}
			if(hatOff == true) 
			{
				OwlAngry.SetActive (false);
				OwlDefault.SetActive (false);
				WithoutHatSleep.SetActive (false);
				OwlSleep.SetActive (false);
				WithoutHatWake.SetActive (true);
			}

		}

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			colliderCount = 1;
			Debug.Log ("Angry");
			totalCount += 1;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			colliderCount = 0;
			Debug.Log ("Default");	
			totalCount += 1;
		}
	}
}