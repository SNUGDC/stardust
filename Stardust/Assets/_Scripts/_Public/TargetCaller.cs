using UnityEngine;
using System.Collections;

public class TargetCaller: MonoBehaviour {


	public GameObject Target;

	GameObject[] targetClass; 

	string targetTag;

	void Start()
	{
		targetTag = Target.gameObject.tag;
		//targetClass = GameObject.FindGameObjectsWithTag (targetTag);
	}

	void Update()
	{
		targetClass = GameObject.FindGameObjectsWithTag (targetTag);
	}

	void OnMouseDown()
	{
		foreach (GameObject target in targetClass) 
		{
			target.SetActive (false);
		}
		Target.SetActive (true);
		GetComponentInParent<newPaletteCaller> ().active = false;//Palette erase
	}
}







