﻿using UnityEngine;
using System.Collections;

public class RabbitEarChop : MonoBehaviour {

    public Animator Clockgive;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (this.gameObject.activeInHierarchy == true) 
		{
            Clockgive.SetBool("Clockgive", true);
		}
	}
}
