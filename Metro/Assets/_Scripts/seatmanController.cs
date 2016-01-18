using UnityEngine;
using System.Collections;

public class seatmanController : MonoBehaviour {

	public Sprite Getup;
	public Sprite Getmove;
	public Sprite Seat;

	void Start () {
		StartCoroutine (moveanim ());
	
	}

	IEnumerator moveanim()
	{
		yield return new WaitForSeconds (0.5f);
		GetComponent<SpriteRenderer> ().sprite = Getmove;
		GetComponent<Rigidbody2D> ().velocity = new Vector3 (1.5f, 0, 0);
		yield return new WaitForSeconds(2);
		GetComponent<Rigidbody2D> ().velocity = new Vector3 (0, 0, 0);
		GetComponent<SpriteRenderer> ().sprite = Getup;
		yield return new WaitForSeconds (0.5f);
		GetComponent<SpriteRenderer> ().sprite = Seat;

	}
}
