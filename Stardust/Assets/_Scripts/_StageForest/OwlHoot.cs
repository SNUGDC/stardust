using UnityEngine;
using System.Collections;

public class OwlHoot : MonoBehaviour {

	public GameObject OwlDefault;
	public GameObject OwlAngry;
	public GameObject WithoutHatowl;
	private int totalCount;
	private int colliderCount = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (totalCount < 6) 
		{
			if (colliderCount == 1) {
				OwlAngry.SetActive (true);
				OwlDefault.SetActive (false);
			} else if (colliderCount == 0) {
				OwlAngry.SetActive (false);
				OwlDefault.SetActive (true);
			} 
		}
		if (totalCount >= 6) 
		{
			Debug.Log ("withoutHat");
			OwlAngry.SetActive (false);
			OwlDefault.SetActive (false);
			WithoutHatowl.SetActive (true);
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
