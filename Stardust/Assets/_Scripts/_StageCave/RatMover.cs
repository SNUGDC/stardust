using UnityEngine;
using System;
using System.Collections;

public class RatMover : MonoBehaviour
{

    public GameObject Cheese;
    public GameObject Player;
    public GameObject Rock;

    public float speed;

    public int actPhase = 3;
    
	void Update () {

	    if (Cheese.activeInHierarchy && Mathf.Abs(transform.position.x - Player.transform.position.x) < 3 && actPhase != 2 && actPhase != 0)
	    {
	        actPhase = 1;
	    }

	    if (actPhase == 1 && Mathf.Abs(transform.position.x - Player.transform.position.x) < 3)
	    {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

	    if (actPhase == 2)
	    {
	        StartCoroutine(PushRock());
	    }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Rock")
        {
            Debug.Log("Rock");
            actPhase = 2;
        }
    }

    IEnumerator PushRock()
    {
        transform.Translate(speed*Time.deltaTime/2, 0, 0);
        yield return new WaitForSeconds(10);
        actPhase = 0;
    }
}
