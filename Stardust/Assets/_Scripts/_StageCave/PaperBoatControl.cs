using UnityEngine;
using System.Collections;

public class PaperBoatControl : MonoBehaviour {

	private bool active;
	public GameObject Pond;

	// Update is called once per frame
	void LateUpdate () {

		if (Input.GetMouseButtonDown(0))
		{
			if (active == true)
			{
				this.gameObject.SetActive (true);

			}
			else
			{
				GetComponentInParent<touchedTargetCaller> ().enabled = true;
				this.gameObject.SetActive (false);
			}
			active = false;
		}
	}

	void OnMouseDown()
	{
		active = true;
		Pond.GetComponent<touchedTargetCaller> ().enabled = false;

	}

}
