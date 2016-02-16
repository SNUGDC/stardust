using UnityEngine;
using System.Collections;

public class TargetPaletteCallerWhenClicked : MonoBehaviour {

	GameObject[] MyPalettes;
	public PaletteCaller Target;
	//int clickCount = 0;

	string MyPaletteTag;
	/*
	void Start()
	{
		MyPaletteTag = this.gameObject.tag;
		MyPalettes = GameObject.FindGameObjectsWithTag (MyPaletteTag);
	}

	//string targetTag;

	void Update()
	{
		if (MyPalettes [0].GetComponent<TargetPaletteCallerWhenClicked> ().clickCount == 1 || MyPalettes [1].GetComponent<TargetPaletteCallerWhenClicked> ().clickCount == 1 || MyPalettes [2].GetComponent<TargetPaletteCallerWhenClicked> ().clickCount == 1) 
		{
			Target.GetComponent<PaletteCaller> ().enabled = true;
			clickCount = 0;
			Debug.Log ("Why2?");
		}
	}
	*/

	void OnMouseDown()
	{
		//clickCount = 1;
		Target.GetComponent<PaletteCaller> ().enabled = true;

	}
}




