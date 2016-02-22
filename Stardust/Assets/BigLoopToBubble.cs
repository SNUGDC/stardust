using UnityEngine;
using System.Collections;

public class BigLoopToBubble : MonoBehaviour
{

    public GameObject SmallBubble;
    private Vector3 tempPosition;

    private bool isSmallBubbleHere = false;

	void Start ()
	{
	    tempPosition = transform.position;
	    if (SmallBubble.GetComponent<SmallLoopToBubble>().AnimEnd == true)
	    {
	        isSmallBubbleHere = true;
	    }
	}
	
	// Update is called once per frame
	void Update () {
	    if (this.gameObject.activeInHierarchy)
	    {
	        Destroy(GetComponentInParent<Collider2D>());
	        GetComponent<Animator>().SetBool("BigBubble",true);
	        if (isSmallBubbleHere == true)
	        {
	            SmallBubble.GetComponent<Animator>().enabled = false;
	            SmallBubble.GetComponent<Transform>().Translate(transform.position - tempPosition);
	            tempPosition = transform.position;
	        }
	    }
	}
}
