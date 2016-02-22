using UnityEngine;
using System.Collections;

public class ParentColliderDestroyer: MonoBehaviour {

	public bool triggerWork;

	public GameObject Parent;

	void Update()
	{
		if (triggerWork == true) {
			Destroy (Parent.GetComponent<Collider2D> ());
		} 
		triggerWork = false;


	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			triggerWork = true;
		}
	}
}