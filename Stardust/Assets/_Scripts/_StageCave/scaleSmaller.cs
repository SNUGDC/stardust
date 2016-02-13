using UnityEngine;
using System.Collections;

public class scaleSmaller: MonoBehaviour {

	Vector3 defaultScale = new Vector3(2, 2, 1);
	public Vector3 newScale = new Vector3(0.75f, 0.75f,1);
	public bool scaled = false;
	public bool triggerWork = false;

	public GameObject Target;
	//public GameObject Parent;

	void Start()
	{
		StartCoroutine ("Delay");
	}

	IEnumerator Delay()//why dont work?
	{
		yield return new WaitForSeconds(5f);
	}

	void Update()
	{
		if (triggerWork == true) {
			if (Target.GetComponent<Transform> ().localScale != newScale) {
				Target.GetComponent<Transform> ().localScale -= new Vector3 (0.25f, 0.25f, 0);
				scaled = true;
				//Destroy (Parent.GetComponent<Collider2D> ());
			} else {
				triggerWork = false;
			}
		} 
		/*
		else
		{
			Target.GetComponent<Transform> ().localScale = defaultScale;
			scaled = false;
		}
		*/

	
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player") {
			triggerWork = true;
		}
	}
}