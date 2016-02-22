using UnityEngine;
using System.Collections;

public class JongyusukCaller : MonoBehaviour {


	public GameObject[] JongYusukClass;//saving jongyusuk in array
	GameObject[] paletteClass;// saving palettes in array
    public Animator BeargetmeatAni;

	public int ClickCount = 0;//check the click count of palette

	public string PaletteTag;

	void Start()
	{
		paletteClass = GameObject.FindGameObjectsWithTag (PaletteTag);
	}

	void OnMouseDown()
	{	
		ClickCount = 1;
		if (paletteClass[0].GetComponent<JongyusukCaller> ().ClickCount == 1) {
			JongYusukClass[0].SetActive (true);
			paletteClass[0].GetComponent<JongyusukCaller> ().ClickCount = 0;
			JongYusukClass[1].SetActive (false);
			JongYusukClass[2].SetActive (false);
		} else if (paletteClass[1].GetComponent<JongyusukCaller> ().ClickCount == 1) {
			JongYusukClass[1].SetActive (true);
			paletteClass[1].GetComponent<JongyusukCaller> ().ClickCount = 0;
			JongYusukClass[0].SetActive (false);
			JongYusukClass[2].SetActive (false);
		} else if (paletteClass[2].GetComponent<JongyusukCaller> ().ClickCount == 1) {
			JongYusukClass[2].SetActive (true);
            BeargetmeatAni.SetBool("bearmoving", true);
			paletteClass [2].GetComponent<JongyusukCaller> ().ClickCount = 0;
			JongYusukClass[0].SetActive (false);
			JongYusukClass[1].SetActive (false);
		}
	}
}