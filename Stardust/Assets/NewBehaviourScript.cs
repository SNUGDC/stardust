using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    
	void Start ()
	{
	    StartCoroutine(TagChange());
	}
	
	void Update () {
	
	}

    IEnumerator TagChange()
    {
        yield return new WaitForSeconds(2);

        this.tag = "Cotton";
    }
    
}
