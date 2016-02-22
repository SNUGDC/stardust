using UnityEngine;
using System.Collections;

public class RabbitChanger : MonoBehaviour
{

    public GameObject Balloon1Bright;
    public GameObject Balloon2Bright;

    public GameObject RabbitDark;
    public GameObject RabbitBright;

    public Collider2D Balloon1Collider;
    public Collider2D Balloon2Collider;

	void Update () {

	    if (Balloon1Bright.activeInHierarchy && Balloon2Bright.activeInHierarchy)
	    {
	        RabbitDark.SetActive(false);
            RabbitBright.SetActive(true);

            Destroy(Balloon1Collider);
            Destroy(Balloon2Collider);
	    }
	
	}
}
