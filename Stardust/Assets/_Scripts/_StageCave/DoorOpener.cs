using UnityEngine;
using System.Collections;

public class DoorOpener : MonoBehaviour {

	public GameObject Target;
	public GameObject ExchangedTarget;
	public Collider2D[] CorrectCrystals;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {

		if (CorrectCrystals [0].enabled == false && CorrectCrystals [1].enabled == false && CorrectCrystals [2].enabled == false && CorrectCrystals [3].enabled == false) 
		{
			Target.SetActive (false);

			ExchangedTarget.SetActive (true);
		}
	
	}
}
