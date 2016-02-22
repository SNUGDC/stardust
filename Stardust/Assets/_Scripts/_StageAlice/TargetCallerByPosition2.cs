using UnityEngine;
using System.Collections;

public class TargetCallerByPosition2 : MonoBehaviour {

	public GameObject Target;
	public GameObject[] PositionClass;
	public GameObject[] Positions;


	// Use this for initialization
	void Start () {
		Target.SetActive (false);

	}

	// Update is called once per frame
	void Update () {

		if (PositionClass [2].activeInHierarchy == true && PositionClass [5].activeInHierarchy == true && PositionClass [8].activeInHierarchy == true && PositionClass [11].activeInHierarchy == true) 
		{
			Target.SetActive (true);
			for (int i = 0; i < PositionClass.GetLength (0); i++) {
				PositionClass [i].SetActive (false);
			}
			foreach(GameObject position in Positions)
			{
				position.GetComponent<Collider2D> ().enabled = false;
			}

		}
	}
}
