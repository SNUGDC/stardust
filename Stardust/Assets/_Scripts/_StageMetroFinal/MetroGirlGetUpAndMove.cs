using UnityEngine;
using System.Collections;

public class MetroGirlGetUpAndMove : MonoBehaviour {



	public GameObject move;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (Movegirl());
	}

	IEnumerator Movegirl(){
		yield return new WaitForSeconds (1.0f);
		this.gameObject.SetActive (false);
		move.SetActive (true);
	}
}
