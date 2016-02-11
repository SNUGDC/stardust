using UnityEngine;
using System.Collections;

public class ButtonCaller : MonoBehaviour {


	public string Buttontag;

	GameObject[] Buttons;
	Vector3[] tempPos;
	Vector3[] temp;
	int routine = 0;
	public bool active = false;
	public float smoothTime = 0.18f;

	private Vector3[] velocity;

	void Start () {

		Buttons = GameObject.FindGameObjectsWithTag (Buttontag);

		tempPos = new Vector3[Buttons.GetLength(0)];
		temp = new Vector3[Buttons.GetLength (0)];
		velocity = new Vector3[Buttons.GetLength (0)];
		for (int i = 0; i < Buttons.GetLength (0); i++) 
		{
			tempPos[i] = Buttons[i].transform.position;
			Buttons [i].SetActive (false);
		}
	}

	void Update () 
	{

		if (Input.GetMouseButton(0))
		{
			if (active == true) 
			{
				routine = 1;
			}
			else 
			{
				routine = 2;
			}
		}
		if (routine == 1) 
		{
			ButtonCall ();
		}

		if (routine == 2) // bool 'active' is false
		{
			ButtonExit ();
		}
	}

	void ButtonCall ()
	{
		for (int i = 0; i < Buttons.GetLength(0); i++) 
		{
			Buttons [i].SetActive (true);
			temp[i] = Vector3.SmoothDamp(Buttons[i].transform.position, tempPos[i], ref velocity[i], smoothTime);
			Buttons[i].transform.position = temp[i];
		}
	}

	void ButtonExit()
	{
		for (int i = 0; i < Buttons.GetLength (0); i++)
			Buttons [i].SetActive (false);
	}

	void OnMouseDown()
	{
		active = true;
		for (int i = 0; i < Buttons.GetLength(0); i++) 
		{
			Buttons[i].transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}
	}
}