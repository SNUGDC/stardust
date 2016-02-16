using UnityEngine;
using System.Collections;

public class TargetPaletteCaller : MonoBehaviour {

	public GameObject Mine;
	public PaletteCaller Target;
	GameObject[] targetClass;

	string targetTag;

	void Update()
	{
	    if (Mine.activeInHierarchy == true) 
		{
			Target.GetComponent<PaletteCaller> ().enabled = true;
		}
		//targetClass = GameObject.FindGameObjectsWithTag (targetTag);
	}
}


