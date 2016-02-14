using UnityEngine;
using System.Collections;

public class CrystalCaller : MonoBehaviour {

	public GameObject[] CrystalClass;//saving crystals in array
	public GameObject[] paletteClass;// saving palettes in array

	public int ClickCount = 0;//check the click count of palette

	//public string PaletteTag;

	/*
	void Start()
	{
		paletteClass = GameObject.FindGameObjectsWithTag (PaletteTag);
	}
	*/

	void OnMouseDown()
	{	
		ClickCount = 1;
		if(paletteClass[0].GetComponent<CrystalCaller>().ClickCount == 1 && paletteClass[1].GetComponent<CrystalCaller>().ClickCount == 0 && paletteClass[2].GetComponent<CrystalCaller>().ClickCount == 0) 
		{
			CrystalClass [0].SetActive (true);
			CrystalClass [7].SetActive (false);//blue crystal on

			if (paletteClass [3].GetComponent<CrystalCaller> ().ClickCount == 1) 
			{
				CrystalClass [0].SetActive (false);
				CrystalClass [7].SetActive (true);
				paletteClass [0].GetComponent<CrystalCaller> ().ClickCount = 0;
				paletteClass [1].GetComponent<CrystalCaller> ().ClickCount = 0;
				paletteClass [2].GetComponent<CrystalCaller> ().ClickCount = 0;
			}
		}
		if(paletteClass[1].GetComponent<CrystalCaller>().ClickCount == 1 && paletteClass[0].GetComponent<CrystalCaller>().ClickCount == 0 && paletteClass[2].GetComponent<CrystalCaller>().ClickCount == 0) 
		{
			CrystalClass [1].SetActive (true);
			CrystalClass [7].SetActive (false);//green Crystal on
			if (paletteClass [3].GetComponent<CrystalCaller> ().ClickCount == 1) 
			{
				CrystalClass [1].SetActive (false);
				CrystalClass [7].SetActive (true);
				paletteClass [0].GetComponent<CrystalCaller> ().ClickCount = 0;
				paletteClass [1].GetComponent<CrystalCaller> ().ClickCount = 0;
				paletteClass [2].GetComponent<CrystalCaller> ().ClickCount = 0;
			}
		}
		if (paletteClass [2].GetComponent<CrystalCaller> ().ClickCount == 1 && paletteClass [0].GetComponent<CrystalCaller> ().ClickCount == 0 && paletteClass [1].GetComponent<CrystalCaller> ().ClickCount == 0) {
			
			CrystalClass [2].SetActive (true);
			CrystalClass [7].SetActive (false);//red crystal on
			if (paletteClass [3].GetComponent<CrystalCaller> ().ClickCount == 1) {
				CrystalClass [2].SetActive (false);
				CrystalClass [7].SetActive (true);
				paletteClass [0].GetComponent<CrystalCaller> ().ClickCount = 0;
				paletteClass [1].GetComponent<CrystalCaller> ().ClickCount = 0;
				paletteClass [2].GetComponent<CrystalCaller> ().ClickCount = 0;
			}
		} else if (paletteClass [0].GetComponent<CrystalCaller> ().ClickCount == 1 && paletteClass [1].GetComponent<CrystalCaller> ().ClickCount == 1 && paletteClass [2].GetComponent<CrystalCaller> ().ClickCount == 0) {
			CrystalClass [3].SetActive (true);
			CrystalClass [0].SetActive (false);
			CrystalClass [1].SetActive (false);
			if (paletteClass [3].GetComponent<CrystalCaller> ().ClickCount == 1) {
				CrystalClass [3].SetActive (false);
				CrystalClass [7].SetActive (true);
				paletteClass [0].GetComponent<CrystalCaller> ().ClickCount = 0;
				paletteClass [1].GetComponent<CrystalCaller> ().ClickCount = 0;
				paletteClass [2].GetComponent<CrystalCaller> ().ClickCount = 0;
			}

		} else if (paletteClass [0].GetComponent<CrystalCaller> ().ClickCount == 1 && paletteClass [2].GetComponent<CrystalCaller> ().ClickCount == 1 && paletteClass [1].GetComponent<CrystalCaller> ().ClickCount == 0) {
			CrystalClass [4].SetActive (true);
			CrystalClass [0].SetActive (false);
			CrystalClass [2].SetActive (false);
			if (paletteClass [3].GetComponent<CrystalCaller> ().ClickCount == 1) {
				CrystalClass [4].SetActive (false);
				CrystalClass [7].SetActive (true);
				paletteClass [0].GetComponent<CrystalCaller> ().ClickCount = 0;
				paletteClass [1].GetComponent<CrystalCaller> ().ClickCount = 0;
				paletteClass [2].GetComponent<CrystalCaller> ().ClickCount = 0;
			}
		} else if (paletteClass [1].GetComponent<CrystalCaller> ().ClickCount == 1 && paletteClass [2].GetComponent<CrystalCaller> ().ClickCount == 1 && paletteClass [0].GetComponent<CrystalCaller> ().ClickCount == 0) {
			CrystalClass [5].SetActive (true);
			CrystalClass [1].SetActive (false);
			CrystalClass [2].SetActive (false);
			if (paletteClass [3].GetComponent<CrystalCaller> ().ClickCount == 1) {
				CrystalClass [5].SetActive (false);
				CrystalClass [7].SetActive (true);
				paletteClass [0].GetComponent<CrystalCaller> ().ClickCount = 0;
				paletteClass [1].GetComponent<CrystalCaller> ().ClickCount = 0;
				paletteClass [2].GetComponent<CrystalCaller> ().ClickCount = 0;
			}
		} else if (paletteClass [0].GetComponent<CrystalCaller> ().ClickCount == 1 && paletteClass [1].GetComponent<CrystalCaller> ().ClickCount == 1 && paletteClass [2].GetComponent<CrystalCaller> ().ClickCount == 1) {
			CrystalClass [6].SetActive (true);
			for (int i = 0; i < 6; i++) {
				CrystalClass [i].SetActive (false);
			}
			if (paletteClass [3].GetComponent<CrystalCaller> ().ClickCount == 1) 
			{
				CrystalClass [6].SetActive (false);
				CrystalClass [7].SetActive (true);
				paletteClass [0].GetComponent<CrystalCaller> ().ClickCount = 0;
				paletteClass [1].GetComponent<CrystalCaller> ().ClickCount = 0;
				paletteClass [2].GetComponent<CrystalCaller> ().ClickCount = 0;
			}
		}

		GetComponentInParent<PaletteCaller> ().active = false;
	}
}


