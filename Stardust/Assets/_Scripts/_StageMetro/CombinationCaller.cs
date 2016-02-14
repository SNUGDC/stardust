
using UnityEngine;
using System.Collections;

public class CombinationCaller : MonoBehaviour {


	public GameObject Target;

	GameObject[] targetClass;
	GameObject[] combiClass;// saving palettes in array include myself

	public int CombiCount = 0;

	public GameObject TaegukObject;

	string targetTag;

	string combiTag;

	void Start()
	{
		targetTag = Target.gameObject.tag;
		combiTag = this.tag;
		combiClass = GameObject.FindGameObjectsWithTag (combiTag);
	}

	void Update()
	{
		targetClass = GameObject.FindGameObjectsWithTag (targetTag);
	}

	void OnMouseDown()
	{
		foreach (GameObject target in targetClass) // all target of palette will be setActive(false)
		{
			target.SetActive (false);
		}
		Target.SetActive (true);//when we click button target of palette will be SetActive(true)

		CombiCount = 1;//CombiCount of 'palette'

		//
		if (combiClass[0].GetComponent<CombinationCaller>().CombiCount ==1 && combiClass[1].GetComponent<CombinationCaller>().CombiCount ==1 && combiClass[2].GetComponent<CombinationCaller>().CombiCount ==1) 
		{
			Target.SetActive(false);
			TaegukObject.SetActive(true);
		}

		GetComponentInParent<touchedPaletteCaller> ().active = false;//Palette erase
	}


}


