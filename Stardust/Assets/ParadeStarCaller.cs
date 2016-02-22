using UnityEngine;
using System.Collections;

public class ParadeStarCaller : MonoBehaviour
{

    public GameObject[] Targets;
    public GameObject star;

	void Update () {

	    if (Targets[0].activeInHierarchy && Targets[1].activeInHierarchy && Targets[2].activeInHierarchy)
	    {
	        star.SetActive(true);
	    }

	}
}
