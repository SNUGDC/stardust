using UnityEngine;
using System.Collections;

public class CrowdController : MonoBehaviour {
	
	Animator anim;

	public GameObject[] baseSprites;
    public GameObject Collidercontroll;
	public Sprite NewSprite;
	
	void Awake()
	{
		anim = GetComponent<Animator> ();

		StartCoroutine (crowdDelay());
	}

	IEnumerator crowdDelay()
	{
		yield return new WaitForSeconds (1);

		anim.SetTrigger ("GentlemanWalk");

		GetComponentInParent<Collider2D> ().enabled = false;

		foreach (GameObject baseSprite in baseSprites)
        {
			baseSprite.GetComponent<SpriteRenderer> ().sprite = NewSprite;
		}
        Collidercontroll.GetComponent<ColliderControll>().Condition = true;
    }
	
}
