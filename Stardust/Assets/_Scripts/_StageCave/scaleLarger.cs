using UnityEngine;
using System.Collections;

public class scaleLarger: MonoBehaviour {

	//Vector3 defaultScale = new Vector3(0.75f, 0.75f,1);
	public Vector3 newScale = new Vector3(2,2,1);
	public bool scaled = false;
	public bool triggerWork;

	public GameObject Target;
	public GameObject Parent;

	void Update()
	{
		if (triggerWork == true) {
			if (Target.GetComponent<Transform> ().localScale != newScale) {
				Target.GetComponent<Transform> ().localScale += new Vector3 (0.25f, 0.25f, 0);
				scaled = true;
				Destroy (Parent.GetComponent<Collider2D> ());
				Destroy (this.GetComponent<Collider2D> ());
			} else {
				this.gameObject.SetActive (false);
			}
		} 
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			triggerWork = true;
		}
	}
}