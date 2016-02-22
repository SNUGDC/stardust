using UnityEngine;
using System.Collections;

public class DestroyByTarget : MonoBehaviour {

	public GameObject Target;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (Target.activeInHierarchy == true) 
		{
			this.gameObject.GetComponent<Collider2D> ().enabled = false;
		}
	
	}
}
