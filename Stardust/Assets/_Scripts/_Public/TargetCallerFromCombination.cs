using UnityEngine;
using System.Collections;

public class TargetCallerFromCombination : MonoBehaviour {


	public GameObject Target;

	public GameObject[] combiClass;// saving palettes in array include myself

	//public int CombiCount = 0;


	void Update()
	{
		if (combiClass[0].activeInHierarchy == true && combiClass[2].activeInHierarchy == true) 
		{
			Debug.Log ("blue");
			Target.SetActive(true);

		}
		else if (combiClass[1].activeInHierarchy == true && combiClass[3].activeInHierarchy == true ) 
		{
			Debug.Log ("green");
			Target.SetActive(true);
			//CombiCount = 0;
		}
		//GetComponentInParent<touchedPaletteCaller> ().active = false;//Palette erase
	}


}


