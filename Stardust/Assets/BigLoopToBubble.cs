using UnityEngine;
using System.Collections;

public class BigLoopToBubble : MonoBehaviour {


	void Start () {
        	
	}
	
	// Update is called once per frame
	void Update () {
	    if (this.gameObject.activeInHierarchy)
	    {
	        Destroy(GetComponentInParent<CircleCollider2D>());
	        GetComponent<Animator>().SetBool("BigBubble",true);
            
	    }
	}
}
