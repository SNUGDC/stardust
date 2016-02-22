using UnityEngine;
using System.Collections;

public class JabberworckyStar : MonoBehaviour {

	public GameObject[] JabberworchkyClass;
	public GameObject ClearStar;
	// Use this for initialization
	void Start () 
	{
		ClearStar.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if( JabberworchkyClass[0].activeInHierarchy == true && JabberworchkyClass[1].activeInHierarchy == true && JabberworchkyClass[2].activeInHierarchy == true)
		{
			ClearStar.SetActive(true);
//			foreach (GameObject Jabberworchky in JabberworchkyClass)
//			{
//				Jabberworchky.GetComponent<Collider2D>().enabled = false;
//			}
		}
	
	}
}
