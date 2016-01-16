using UnityEngine;
using System.Collections;

public class PaletteCaller : MonoBehaviour {


	public string tag = "";

	GameObject[] Palettes;
	Vector3[] tempPos;
	Vector3[] temp;

	public bool active = false;
	public float smoothTime = 0.1f;

	private Vector3[] velocity;

	void Start () {
	
		Palettes = GameObject.FindGameObjectsWithTag (tag);//Making array which collects palette's' belong to some tage

		tempPos = new Vector3[Palettes.GetLength(0)];
		temp = new Vector3[Palettes.GetLength (0)];
		velocity = new Vector3[Palettes.GetLength (0)];
		for (int i = 0; i < Palettes.GetLength (0); i++) 
		{
			tempPos[i] = Palettes[i].transform.position;//Palettes is array which size is as same as the number of GameObject 'tag'
		}	//and tempPos[i] remember switched position of Palettes[i]

	}

	void Update () {

		foreach (GameObject palette in Palettes) 
		{
			palette.SetActive (active);
		}

		for (int i = 0; i < Palettes.GetLength(0); i ++) 
		{
			temp[i] = Vector3.SmoothDamp(Palettes[i].transform.position, tempPos[i], ref velocity[i], smoothTime);
			//move the palette by frame smoothly(SmoothDamp) and substitude its position value to temp[i]
			Palettes[i].transform.position = temp[i];//remember position of moved palette per frame 
		}
	}

	void OnMouseDown()
	{
		active = !active;
		for (int i = 0; i < Palettes.GetLength(0); i++) 
		{
			Palettes[i].transform.position = transform.position;
		}
	}

}













