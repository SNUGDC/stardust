using UnityEngine;
using System.Collections;

public class StarActive : MonoBehaviour
{

    public Sprite Star;
    public GameObject Target;

    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = null;
    }

	void Update () {

	    if (Target.activeInHierarchy == true)
	    {
	        GetComponent<SpriteRenderer>().sprite = Star;
	    }
	}
}
