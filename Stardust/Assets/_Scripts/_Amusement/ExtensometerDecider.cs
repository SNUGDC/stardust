﻿using UnityEngine;
using System.Collections;

public class ExtensometerDecider : MonoBehaviour {

	public GameObject ExtensometerTarget;
	public GameObject DragonTarget;
	public GameObject DragonExTarget;
	// Use this for initialization
	void Start () {
		DragonTarget.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (ExtensometerTarget.activeInHierarchy == true) 
		{
			this.gameObject.GetComponent<Collider2D> ().enabled = false;
			DragonTarget.SetActive (true);
			DragonExTarget.SetActive (false);
		}
	}
}