using UnityEngine;
using System.Collections;

public class PaperCaller : MonoBehaviour {

	public GameObject[] PaperClass;//saving crystals in array
	public GameObject[] paletteClass;// saving palettes in array
	public GameObject Target;
	public GameObject Root;

	public int ClickCount = 0;//check the click count of palette




	void OnMouseDown()
	{	
		ClickCount = 1;

		if (paletteClass [0].GetComponent<PaperCaller> ().ClickCount == 1) 
		{
			paletteClass[0].SetActive (true);
			paletteClass[2].SetActive (false);

		}
		if (paletteClass [1].GetComponent<PaperCaller> ().ClickCount == 1) 
		{
			paletteClass[1].SetActive (true);
			paletteClass[2].SetActive (false);
		}
		if (paletteClass [0].GetComponent<PaperCaller> ().ClickCount == 1 && paletteClass [1].GetComponent<PaperCaller> ().ClickCount == 1) 
		{
			paletteClass[0].SetActive (false);
			paletteClass[1].SetActive (false);
			paletteClass [0].GetComponent<PaperCaller> ().ClickCount = 0;
			paletteClass [1].GetComponent<PaperCaller> ().ClickCount = 0;
		}
		if (paletteClass [2].GetComponent<PaperCaller> ().ClickCount == 1) 
		{
			paletteClass[2].SetActive (true);
			paletteClass[0].SetActive (false);
			paletteClass[1].SetActive (false);
			paletteClass [0].GetComponent<PaperCaller> ().ClickCount = 0;
			paletteClass [1].GetComponent<PaperCaller> ().ClickCount = 0;
			paletteClass [2].GetComponent<PaperCaller> ().ClickCount = 0;
		}
		if (paletteClass [3].GetComponent<PaperCaller> ().ClickCount == 1) 
		{
			paletteClass[3].SetActive (true);
			paletteClass[5].SetActive (false);

		}
		if (paletteClass [4].GetComponent<PaperCaller> ().ClickCount == 1) 
		{
			paletteClass[4].SetActive (true);
			paletteClass[5].SetActive (false);

		}
		if (paletteClass [3].GetComponent<PaperCaller> ().ClickCount == 1 && paletteClass [4].GetComponent<PaperCaller> ().ClickCount == 1) 
		{
			paletteClass[3].SetActive (false);
			paletteClass[4].SetActive (false);
			paletteClass [3].GetComponent<PaperCaller> ().ClickCount = 0;
			paletteClass [4].GetComponent<PaperCaller> ().ClickCount = 0;
		}
		if (paletteClass [5].GetComponent<PaperCaller> ().ClickCount == 1) 
		{
			paletteClass[5].SetActive (true);
			paletteClass[3].SetActive (false);
			paletteClass[4].SetActive (false);
			paletteClass [3].GetComponent<PaperCaller> ().ClickCount = 0;
			paletteClass [4].GetComponent<PaperCaller> ().ClickCount = 0;
			paletteClass [5].GetComponent<PaperCaller> ().ClickCount = 0;
		}
		else if (paletteClass [0].GetComponent<PaperCaller> ().ClickCount == 1 && paletteClass [3].GetComponent<PaperCaller> ().ClickCount == 1) 
		{
			Target.SetActive (true);
			Destroy(Root.GetComponent<Collider2D>());
			paletteClass [0].GetComponent<PaperCaller> ().ClickCount = 0;
			paletteClass [3].GetComponent<PaperCaller> ().ClickCount = 0;

		}
		else if (paletteClass [1].GetComponent<PaperCaller> ().ClickCount == 1 && paletteClass [4].GetComponent<PaperCaller> ().ClickCount == 1) 
		{
			Target.SetActive (true);
			Destroy(Root.GetComponent<Collider2D>());
			paletteClass [1].GetComponent<PaperCaller> ().ClickCount = 0;
			paletteClass [4].GetComponent<PaperCaller> ().ClickCount = 0;

		}
		/*	
		else 
		{
			for (int i = 0; i < 6; i++) {
				paletteClass [i].GetComponent<CrystalCaller> ().ClickCount = 0;
			}
		}
		*/

		GetComponentInParent<PaletteCaller> ().active = false;
	}
}

