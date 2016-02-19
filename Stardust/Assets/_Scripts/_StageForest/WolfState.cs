using UnityEngine;
using System.Collections;

public class WolfState : MonoBehaviour {

	private bool getHat;
	private bool rainedHat;
	public GameObject[] WolfFeeling;
	public GameObject[] OwlWithoutHat;
	public GameObject RainFlower;

	// Use this for initialization
	void Start () {
		getHat = false;
		WolfFeeling[0].SetActive(true);
	
	}
	
	// Update is called once per frame
	void Update () {
		OwlHatRainState ();
	}

	void OwlHatRainState()
	{
		if (OwlWithoutHat [0].activeInHierarchy == true || OwlWithoutHat [1].activeInHierarchy == true) {
			getHat = true;
		} else if (OwlWithoutHat [0].activeInHierarchy == false && OwlWithoutHat [1].activeInHierarchy == false) 
		{
			getHat = false;
		}
		if (getHat == true && RainFlower.activeInHierarchy == true) {
			rainedHat = true;
		} else
		{
			rainedHat = false;
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			if (rainedHat == true ) {
				WolfFeeling [0].SetActive(false);
				WolfFeeling [1].SetActive(true);
			} else 
			{
				WolfFeeling [0].SetActive(true);
				WolfFeeling [1].SetActive(false);
			}
		}
	}
}
