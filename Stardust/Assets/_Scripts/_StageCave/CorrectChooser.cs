using UnityEngine;
using System.Collections;

public class CorrectChooser : MonoBehaviour {


	public GameObject Target;
	public GameObject ExchangedTarget;
	public Collider2D[] CorrectCrystals;
	// Use this for initialization

	// Update is called once per frame
	void Update () {

		if (CorrectCrystals [0].enabled == true && CorrectCrystals [0].enabled == true && CorrectCrystals [0].enabled == true && CorrectCrystals [0].enabled == true) 
		{
			Target.SetActive (false);

			ExchangedTarget.SetActive (true);
		}

	}
}
