using UnityEngine;
using System.Collections;

public class TargetCallerFromCombination : MonoBehaviour {


	public GameObject Target;
	public GameObject Parent;
    public GameObject Target2;

	public GameObject[] combiClass;// saving palettes in array include myself
    public GameObject[] combiClass2;//

	//public int CombiCount = 0;


	void Update()
	{
		if (combiClass[0].activeInHierarchy == true && combiClass[1].activeInHierarchy == true) 
		{
			Debug.Log ("Green");
			Target.SetActive(true);
			Parent.GetComponent<PaletteCaller> ().enabled = false;
		}	
        /*
		else if (combiClass[2].activeInHierarchy == true && combiClass[3].activeInHierarchy == true ) 
		{
			Debug.Log ("Blue");
			Target.SetActive(true);
			//CombiCount = 0;
		}
		*/
        //GetComponentInParent<touchedPaletteCaller> ().active = false;//Palette erase
    }
}


