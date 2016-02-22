using UnityEngine;
using System.Collections;

public class PanRotate : MonoBehaviour
{
    public bool IsRotating = false;
    public float panspeed = -300;

    public GameObject RibbonGray;
    public GameObject Fan;

	void Update () {
	    if (RibbonGray.activeInHierarchy == false)
	    {
	        IsRotating = true;
	        Fan.transform.Rotate(0f, 0f, panspeed*Time.deltaTime);
	    }
	    else
	    {
	        IsRotating = false;
	    }
	}
}
