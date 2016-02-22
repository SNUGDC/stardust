using UnityEngine;
using System;
using System.Collections;

public class IceSpirit : MonoBehaviour
{

    public GameObject Torch;

    private float InitialLightLange;

    void Start()
    {
        InitialLightLange = Torch.GetComponent<Light>().range;
    }
	
	void Update () {
	    if (Mathf.Abs(Torch.transform.position.x - transform.position.x) <= 7)
	    {
	        Torch.GetComponent<Light>().range = InitialLightLange -
	                                            (7 - Math.Abs(Torch.transform.position.x - transform.position.x))*1.5f;
	    }
	    else
	    {
	        Torch.GetComponent<Light>().range = InitialLightLange;
	    }
	}
}
