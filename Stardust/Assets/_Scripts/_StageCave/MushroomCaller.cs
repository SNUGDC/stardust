using UnityEngine;
using System.Collections;

public class MushroomCaller : MonoBehaviour {


	public GameObject[] mushroomClass;//saving mushrooms in array
	GameObject[] paletteClass;// saving palettes in array

	public int ClickCount = 0;//check the click count of palette

	public string PaletteTag;

	void Start()
	{
		paletteClass = GameObject.FindGameObjectsWithTag (PaletteTag);
	}

	void OnMouseDown()
	{	
		ClickCount = 1;
		if (paletteClass[0].GetComponent<MushroomCaller>().ClickCount ==1 && paletteClass[1].GetComponent<MushroomCaller>().ClickCount ==1) 
		{
			mushroomClass [0].SetActive (true);
			paletteClass [0].GetComponent<MushroomCaller> ().ClickCount = 0;
			paletteClass [1].GetComponent<MushroomCaller> ().ClickCount = 0;
			mushroomClass [1].SetActive (false);
			mushroomClass [2].SetActive (false);
		}
		else if (paletteClass[0].GetComponent<MushroomCaller>().ClickCount ==1 && paletteClass[2].GetComponent<MushroomCaller>().ClickCount ==1) 
		{
			mushroomClass [1].SetActive (true);
			paletteClass [0].GetComponent<MushroomCaller> ().ClickCount = 0;
			paletteClass [2].GetComponent<MushroomCaller> ().ClickCount = 0;
			mushroomClass [0].SetActive (false);
			mushroomClass [2].SetActive (false);
		}
		else if (paletteClass[1].GetComponent<MushroomCaller>().ClickCount ==1 && paletteClass[2].GetComponent<MushroomCaller>().ClickCount ==1) 
		{
			mushroomClass [2].SetActive (true);
			paletteClass [1].GetComponent<MushroomCaller> ().ClickCount = 0;
			paletteClass [2].GetComponent<MushroomCaller> ().ClickCount = 0;
			mushroomClass [0].SetActive (false);
			mushroomClass [1].SetActive (false);
		}
		GetComponentInParent<PaletteCaller> ().active = false;

	}
}


