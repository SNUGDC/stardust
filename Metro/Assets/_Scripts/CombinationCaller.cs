/*
using UnityEngine;
using System.Collections;

public class CombinationCaller : MonoBehaviour {


	public GameObject Target;

	private int combiCount = 0;

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
		GetComponentInParent<PaletteCaller> ().active = false;//Palette erase
	}

	void Combination(GameObject Target)
	{
		foreach (GameObject target in targetClass) 
		{
			if (Target.SetActive (true)) 
			{
				combiCount = 1;
			}

		}
	}
}
*/

