using UnityEngine;
using System.Collections;

public class MetroManMove : MonoBehaviour
{


    public GameObject seat;
	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update () {
        seat.GetComponent<MetroTargetExchanger>().active = true;

    }
}
