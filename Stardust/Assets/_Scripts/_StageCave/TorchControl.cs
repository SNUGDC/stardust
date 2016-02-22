using UnityEngine;
using System;
using System.Collections;

public class TorchControl : MonoBehaviour
{

    public GameObject Player;

    public bool torchGet = false;

	void Start () {
	
	}
	
	void Update () {

	    if (torchGet && Player.GetComponent<PlayerController>().facingRight)
	    {
	        transform.position = new Vector3(Player.transform.position.x + 0.8f, Player.transform.position.y, 0);
	    }
	    if (torchGet && Player.GetComponent<PlayerController>().facingRight != true)
	    {
            transform.position = new Vector3(Player.transform.position.x - 0.8f, Player.transform.position.y, 0);
        }
	}

    void OnMouseDown()
    {
        if (Mathf.Abs(Player.transform.position.x - transform.position.x) < 2)
        {
            torchGet = true;
        }
    }
}
