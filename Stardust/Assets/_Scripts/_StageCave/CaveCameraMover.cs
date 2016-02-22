using UnityEngine;
using System.Collections;

public class CaveCameraMover : MonoBehaviour
{

    public GameObject Player;

    void Start()
    {
        transform.position = new Vector3(-79f,0f,-10f);
    }

	void Update () {

	    if (Player.transform.position.x >= -79 && Player.transform.position.x <= 79)
	    {
	        transform.position = new Vector3(Player.transform.position.x,0f, -10f);
	    }
	}
}
