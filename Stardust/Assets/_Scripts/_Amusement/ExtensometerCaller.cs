using UnityEngine;
using System.Collections;

public class ExtensometerCaller : MonoBehaviour {

	public GameObject[] ExtensometerClass;//saving crystals in array
	public GameObject[] paletteClass;// saving palettes in array

	public int ClickCount = 0;//check the click count of palette


	void Start()
	{
		foreach (GameObject extensometer in ExtensometerClass) 
		{
			extensometer.SetActive (false);
		}
		ExtensometerClass [2].SetActive (true);

	}

	void OnMouseDown()
	{	
		ClickCount = 1;

		if (paletteClass [0].GetComponent<ExtensometerCaller> ().ClickCount == 1) {
			ExtensometerClass [2].SetActive (true);
			ExtensometerClass [0].SetActive (false);
			ExtensometerClass [1].SetActive (false);
			ExtensometerClass [3].SetActive (false);
			ExtensometerClass [4].SetActive (false);
			paletteClass [0].GetComponent<ExtensometerCaller> ().ClickCount = 0;

			if (paletteClass [2].GetComponent<ExtensometerCaller> ().ClickCount == 1) {
				ExtensometerClass [2].SetActive (false);
				ExtensometerClass [0].SetActive (false);
				ExtensometerClass [3].SetActive (true);
				paletteClass [0].GetComponent<ExtensometerCaller> ().ClickCount = 0;
				paletteClass [1].GetComponent<ExtensometerCaller> ().ClickCount = 0;
				paletteClass [2].GetComponent<ExtensometerCaller> ().ClickCount = 0;
			} else if (paletteClass [1].GetComponent<ExtensometerCaller> ().ClickCount == 1) {
				ExtensometerClass [2].SetActive (false);
				ExtensometerClass [0].SetActive (false);
				ExtensometerClass [4].SetActive (true);
				paletteClass [0].GetComponent<ExtensometerCaller> ().ClickCount = 0;
				paletteClass [1].GetComponent<ExtensometerCaller> ().ClickCount = 0;
				paletteClass [2].GetComponent<ExtensometerCaller> ().ClickCount = 0;
			}
		} else if (paletteClass [1].GetComponent<ExtensometerCaller> ().ClickCount == 1) 
		{
			ExtensometerClass [0].SetActive (false);
			ExtensometerClass [1].SetActive (true);
			ExtensometerClass [2].SetActive (false);
			ExtensometerClass [3].SetActive (false);
			ExtensometerClass [4].SetActive (false);
			if (paletteClass [0].GetComponent<ExtensometerCaller> ().ClickCount == 1 ) {
				ExtensometerClass [1].SetActive (false);
				ExtensometerClass [4].SetActive (true);
				paletteClass [0].GetComponent<ExtensometerCaller> ().ClickCount = 0;
				paletteClass [1].GetComponent<ExtensometerCaller> ().ClickCount = 0;
				paletteClass [2].GetComponent<ExtensometerCaller> ().ClickCount = 0;
			}else if (paletteClass [2].GetComponent<ExtensometerCaller> ().ClickCount == 1) {
				ExtensometerClass [1].SetActive (false);
				ExtensometerClass [0].SetActive (true);
				paletteClass [0].GetComponent<ExtensometerCaller> ().ClickCount = 0;
				paletteClass [1].GetComponent<ExtensometerCaller> ().ClickCount = 0;
				paletteClass [2].GetComponent<ExtensometerCaller> ().ClickCount = 0;
			}
		}
		else if (paletteClass [2].GetComponent<ExtensometerCaller> ().ClickCount == 1) 
		{
			if (paletteClass [0].GetComponent<ExtensometerCaller> ().ClickCount == 1) {
				ExtensometerClass [0].SetActive (false);
				ExtensometerClass [1].SetActive (false);
				ExtensometerClass [2].SetActive (false);
				ExtensometerClass [3].SetActive (true);
				ExtensometerClass [4].SetActive (false);
				paletteClass [0].GetComponent<ExtensometerCaller> ().ClickCount = 0;
				paletteClass [1].GetComponent<ExtensometerCaller> ().ClickCount = 0;
				paletteClass [2].GetComponent<ExtensometerCaller> ().ClickCount = 0;
			}else if (paletteClass [1].GetComponent<ExtensometerCaller> ().ClickCount == 1) {
				ExtensometerClass [0].SetActive (true);
				ExtensometerClass [1].SetActive (false);
				ExtensometerClass [2].SetActive (false);
				ExtensometerClass [3].SetActive (false);
				ExtensometerClass [4].SetActive (false);
				paletteClass [0].GetComponent<ExtensometerCaller> ().ClickCount = 0;
				paletteClass [1].GetComponent<ExtensometerCaller> ().ClickCount = 0;
				paletteClass [2].GetComponent<ExtensometerCaller> ().ClickCount = 0;
			}
		}
//		GetComponent<PaletteCaller> ().active = false;
	}
}


