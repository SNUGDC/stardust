using UnityEngine;
using System.Collections;

public class PaletteCaller : MonoBehaviour {

	public string PaletteTag;

	GameObject[] Palettes;
	Vector3[] tempPos;
	Vector3[] temp;
	public int routine = 0;
	public bool active;
	public float smoothTime = 0.18f;

	private Vector3[] velocity;


	void Start () {
		Palettes = GameObject.FindGameObjectsWithTag (PaletteTag);
		tempPos = new Vector3[Palettes.GetLength(0)];
		temp = new Vector3[Palettes.GetLength (0)];
		velocity = new Vector3[Palettes.GetLength (0)];
		for (int i = 0; i < Palettes.GetLength (0); i++) 
		{
			tempPos[i] = Palettes[i].transform.position;
			Palettes [i].SetActive (false);
		}
	}

	void Update()
	{
		if (active == true) {
			routine = 1;
		}
		else
		{
			routine = 2;
		}

		if (routine == 1) 
		{
			Debug.Log ("8");
			PaletteCall ();
		}


		if (routine == 2) 
		{
			for (int i = 0; i < Palettes.GetLength(0); i++) 
			{
				Palettes [i].SetActive (false);
			}
			active = false;
		}
	}


	void OnMouseDown()//change start position of Palette
	{
		active = true;
		for (int i = 0; i < Palettes.GetLength(0); i++) 
		{
			Palettes[i].transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}
	}
		

	void PaletteCall ()
	{
		for (int i = 0; i < Palettes.GetLength (0); i++) {
			Palettes [i].SetActive (true);
			temp [i] = Vector3.SmoothDamp (Palettes [i].transform.position, tempPos [i], ref velocity [i], smoothTime);
			Palettes [i].transform.position = temp [i];
		}
	}
}