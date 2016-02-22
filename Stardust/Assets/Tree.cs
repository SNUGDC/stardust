using UnityEngine;
using System.Collections;

public class Tree : MonoBehaviour
{

    public GameObject White;
    public GameObject Orange;
    public GameObject[] Cloud;
    public Collider2D thisCollider;
    public GameObject Pumpkin;

    private int stage = -1;

	void Update () {

	    if (White.GetComponent<TreeChange>().Clicked)
	    {
	        stage = stage + 1;
	        White.GetComponent<TreeChange>().Clicked = false;
	    }
	    if (Orange.GetComponent<TreeChange>().Clicked)
	    {
	        stage = stage - 1;
	        Orange.GetComponent<TreeChange>().Clicked = false;
	    }

	    for (int i = 0; i < Cloud.GetLength(0); i++)
	    {
	        if (i != stage)
	        {
	            Cloud[i].SetActive(false);
	        }
	    }
	    if (-1 < stage && stage < 4)
	    {
	        Cloud[stage].SetActive(true);
	    }

	    if (stage == 3)
	    {
	        Cloud[3].GetComponent<Animator>().SetTrigger("Cloud");
            Destroy(Pumpkin);
            Destroy(thisCollider);
	    }

	    if (stage < -1)
	    {
	        stage = -1;
	    }
	    if (stage > 3)
	    {
	        stage = 3;
	    }
	}
}
