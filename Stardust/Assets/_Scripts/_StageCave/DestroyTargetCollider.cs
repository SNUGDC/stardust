using UnityEngine;
using System.Collections;

public class DestroyTargetCollider: MonoBehaviour {

	public bool triggerWork;

	public GameObject Parent;

	void Update()
	{
		if (triggerWork == true) {
			Debug.Log ("1");
			Parent.GetComponent<Collider2D> ().enabled = false;
			Destroy (this.gameObject.GetComponent<Collider2D> ());
		} 
		triggerWork = false;


	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			Debug.Log ("4");
			triggerWork = true;
		}
	}
}